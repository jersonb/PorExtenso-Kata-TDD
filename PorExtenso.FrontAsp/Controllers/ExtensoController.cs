using Microsoft.AspNetCore.Mvc;
using Repository;

namespace PorExtenso.FrontAsp.Controllers
{
    [ApiController]
    [Route("api/porextenso")]
    public class ExtensoController : ControllerBase
    {
        private readonly DatabaseService _data;

        public ExtensoController(DatabaseService data)
        {
            _data = data;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_data.Get());
        }

        [HttpGet("{value:int}")]
        public IActionResult Get(int value)
        {
            Lib.Extenso extenso = value;

            try
            {
                return Ok(new { response = extenso.ToString() });
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { response = ex.Message });
            }
        }
    }
}