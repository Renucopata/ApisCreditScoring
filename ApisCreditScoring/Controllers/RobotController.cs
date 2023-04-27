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
        [Route("GetRegistroClientes")] //Terminada y probada
        public IActionResult getgbage()
        {
            
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();

            return Ok(insertor.insertGbage(retriever.getgbage()));
        }

       [HttpGet]
        [Route("GetdatosAdicionalesCli")] //Terminada y probada
        public IActionResult getgbdac()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbdac(retriever.getgbdac()));
        }

        [HttpGet]
        [Route("GetDeclaracionCli")] //no hay data en la tabla
        public IActionResult getgbdbi()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbdbi(retriever.getgbdbi()));
        }





        //moduloPrestamosComerciales




        [HttpGet]
        [Route("GetCargosDiferidos")] //Terminada y probada
        public IActionResult getprdif()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertPrdif(retriever.getprdif()));
        }

        [HttpGet]
        [Route("GetDeudores")] //Terminada y probada
        public IActionResult getprdeu()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertPrdeu(retriever.getPrdeu()));
        }


    }
}
