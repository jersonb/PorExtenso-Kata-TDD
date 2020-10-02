using Microsoft.AspNetCore.Mvc;

namespace PorExtenso.FrontAsp.Controllers
{
    [ApiController]
    [Route("api/porextenso")]
    public class ExtensoController : ControllerBase
    {
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