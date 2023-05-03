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

        [HttpGet]
        [Route("GetHistoricoCantPrest")] //tabla sin acceso
        public IActionResult getgbhpr()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbhpr(retriever.getGbhpr()));
        }

        [HttpGet]
        [Route("GetHistoricoSeguroVida")] //tabla sin acceso
        public IActionResult getgbhsv()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbhsv(retriever.getGbhsv()));
        }

        [HttpGet]
        [Route("GetHistoricoTransacciones")] //tabla sin acceso
        public IActionResult getgbhtr()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbhtr(retriever.getGbhtr()));
        }

        [HttpGet]
        [Route("GetProfesionesAgrupacion")] //tabla sin acceso
        public IActionResult getgbprc()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbprc(retriever.getGbprc()));
        }

        [HttpGet]
        [Route("GetProfesiones")] //tabla sin acceso
        public IActionResult getgbprf()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbprf(retriever.getGbprf()));
        }

        [HttpGet]
        [Route("GetTamanoEmpresa")] //tabla sin acceso
        public IActionResult getgbpte()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbpte(retriever.getGbpte()));
        }




        //moduloPrestamosComerciales


        [HttpGet]
        [Route("GetAutorizantes")] //sin acceso a la tabla
        public IActionResult getpraut()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertPraut(retriever.getPraut()));
        }

        [HttpGet]
        [Route("GetCondonacionCapitalCastigado")] //sin acceso a la tabla
        public IActionResult getprckc()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertPrckc(retriever.getPrckc()));
        }

        [HttpGet]
        [Route("GetCuentasCastigoInsolvPrescrip")] //sin acceso a la tabla
        public IActionResult getprcta()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertPrcta(retriever.getPrcta()));
        }

        [HttpGet]
        [Route("GetParametrosControl")] //sin acceso a la tabla
        public IActionResult getprctl()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertPrctl(retriever.getPrctl()));
        }

        [HttpGet]
        [Route("GetHistoricoParametrosControl")] //sin acceso a la tabla
        public IActionResult getprctl_h()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertPrctl_h(retriever.getPrctl_h()));
        }



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
