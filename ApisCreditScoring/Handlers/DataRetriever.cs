using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace ApisCreditScoring.Handlers
{
    public class DataRetriever
    {
        public string getgbage()
        {
           string response;
           var cn = new StageConnection();
           using(var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM general.gbage";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        var dataTable = new DataTable();
                        dataTable.Load(reader);
                        response = JsonConvert.SerializeObject(dataTable);

                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

            }



            return response;
        }

        public string getgbage2(SqlConnection cn)
        {
            string response;
            // var cn = new StageConnection();

            try
            {
                cn.Open();
                string query = "SELECT * FROM general.gbage";
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    response = JsonConvert.SerializeObject(dataTable);

                }
            }
            catch (Exception ex)
            {
                throw;
            }



            return response;
        }

    }
}
