using Microsoft.AspNetCore.Mvc;

namespace PorExtenso.Api.Controllers
{
    [ApiController]
    [Route("porextenso")]
    public class Extenso : ControllerBase
    {
        [HttpGet("{value:int}")]
        public IActionResult Get(int value)
        {
            Lib.Extenso extenso = value;
            return Ok(new { response = extenso.ToString() });
        }
    }
}