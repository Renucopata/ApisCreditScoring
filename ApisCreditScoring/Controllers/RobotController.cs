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
        [Route("GetActividadesCli")] //sin acceso
        public IActionResult getgbaec()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbaec(retriever.getGbaec()));
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
        [Route("GetBeneficiarios")] //sin acceso
        public IActionResult getgbben()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbben(retriever.getGbben()));
        }

        [HttpGet]
        [Route("GetBeneficiosCPOP")] //sin acceso
        public IActionResult getgbcpo()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbcpo(retriever.getGbcpo()));
        }

        [HttpGet]
        [Route("GetEquivalenciasUbi")] //sin acceso
        public IActionResult getgbcsf()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbcsf(retriever.getGbcsf()));
        }

        [HttpGet]
        [Route("GetdatosAdicionalesCli")] //Terminada
        public IActionResult getgbdac()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbdac(retriever.getgbdac()));
        }

        [HttpGet]
        [Route("GetHistoricoDatosAdicionalesCli")] //Terminada
        public IActionResult getgbdac_h()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbdac_h(retriever.getGbdac_h()));
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


        [HttpGet]
        [Route("GetDeudores")] //tabla sin acceso
        public IActionResult getgbdeu()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbdeu(retriever.getGbdeu()));
        }

        [HttpGet]
        [Route("GetDeudasOtrasInst")] //tabla sin acceso
        public IActionResult getgbdgo()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbdgo(retriever.getGbdgo()));
        }

        [HttpGet]
        [Route("GetDatosIndicesPPI")] //tabla sin acceso
        public IActionResult getgbdic()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbdic(retriever.getGbdic()));
        }

        [HttpGet]
        [Route("GetHistoricoDocCliente")] //tabla sin acceso
        public IActionResult getgbdoc_h()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbdoc_h(retriever.getGbdoc_h()));
        }

        [HttpGet]
        [Route("GetCorreosElecAgenda")] //tabla sin acceso
        public IActionResult getgbema()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbema(retriever.getGbema()));
        }

        [HttpGet]
        [Route("GetHistoricoCalificacion")] //tabla sin acceso
        public IActionResult getgbhca()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbhca(retriever.getGbhca()));
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
        [Route("GetDeudoresPR")] //Terminada y probada
        public IActionResult getprdeu()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertPrdeu(retriever.getPrdeu()));
        }


    }
}
