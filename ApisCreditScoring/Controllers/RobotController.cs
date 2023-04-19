using ApisCreditScoring.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ApisCreditScoring.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public RobotController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        [HttpGet] 
        [Route("GetRegistroClientes")]
        public IActionResult getgbage()
        {
            
            DataRetriever pro = new DataRetriever();
            ModelState.Clear();
            return Ok(pro.getgbage());
        }

       [HttpGet]
        [Route("GetdatosAdicionalesCli")]
        public IActionResult getgbdac()
        {
            DataRetriever pro = new DataRetriever();
            ModelState.Clear();
            return Ok(pro.getgbdac());
        }



    }
}
