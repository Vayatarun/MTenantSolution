using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace MTenantSolution.API.Areas.PublicArea
{
    [Area("PublicArea")]
    [DisplayName("Public Controller")]
    [Route("api/[area]/[controller]")]
    [ApiController]
    public class PublicController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is Public Area");
        }

    }
}
