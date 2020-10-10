using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PorExtenso.FrontAsp.Models;
using PorExtenso.Lib;
using Repository;

namespace PorExtenso.FrontAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseService _data;

        public HomeController(ILogger<HomeController> logger, DatabaseService data)
        {
            _logger = logger;
            _data = data;
        }

        public IActionResult Index()
        {
            return View(new Requisicao());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> Index([Bind("Numero", "NomeUsuario")] Requisicao requisicao)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Extenso extenso = requisicao.Numero ?? 0;
                    requisicao.Descricao = $"{requisicao.NomeUsuario} seu valor é {extenso}";

                    var consulta = new Consulta
                    {
                        Extenso = requisicao.Descricao,
                        ValorConsultado = requisicao.Numero.Value,
                        NameUser = requisicao.NomeUsuario
                    };

                    _data.Create(consulta);
                }
                catch (Exception ex)
                {
                    requisicao.Descricao = ex.Message;
                }
                await Task.WhenAll();
                return View("Index", requisicao);
            }

            return View("Index", requisicao);
        }
    }
}