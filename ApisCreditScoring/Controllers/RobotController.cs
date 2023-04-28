﻿using ApisCreditScoring.Handlers;
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
        [Route("GetdatosAdicionalesCli")] //Terminada y probada
        public IActionResult getgbdac()
        {
            DataRetriever retriever = new DataRetriever();
            ModelState.Clear();
            DataInsertor insertor = new DataInsertor();
            return Ok(insertor.insertGbdac(retriever.getgbdac()));
        }

        [HttpGet]
        [Route("GetHistoricoDatosAdicionalesCli")] //Terminada y probada
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
