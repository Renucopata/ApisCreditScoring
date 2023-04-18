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
        [Route("GetRegistroClientes2")]
        public IActionResult getgage2()
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("ConexionStage").ToString());
            DataRetriever pro = new DataRetriever();
            ModelState.Clear();
            return Ok(pro.getgbage2(connection));
        }



    }
}
