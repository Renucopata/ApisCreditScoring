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
            
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();

            return Ok(insertor.insertGbage(retriever.getgbage()));
        }

       [HttpGet]
        [Route("GetdatosAdicionalesCli")]
        public IActionResult getgbdac()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            return Ok(retriever.getgbdac());
        }

        [HttpGet]
        [Route("GetDeclaracionCli")]
        public IActionResult getgbdbi()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            return Ok(retriever.getgbdbi());
        }


    }
}
