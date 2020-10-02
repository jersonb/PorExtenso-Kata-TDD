using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PorExtenso.FrontAsp.Models;
using PorExtenso.Lib;

namespace PorExtenso.FrontAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
        public async Task<IActionResult> Index([Bind("Numero")] Requisicao requisicao)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Extenso extenso = requisicao.Numero ?? 0;
                    requisicao.Descricao = $"Seu valor é {extenso}";
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
