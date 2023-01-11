using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcorewebapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        IConfiguration _configuration;

        public DemoController(IConfiguration inConfig) 
        {
            _configuration = inConfig;
        } 

        [HttpGet]
        public IActionResult index()
        {
            return Ok(new
            {
                message="index 88888"
            });
        }

        [HttpGet("index2")]
        public IActionResult index2()
        {
            return Ok(new
            {
                message = "new " + _configuration["env"].ToString()
            });
        }


    }
}
