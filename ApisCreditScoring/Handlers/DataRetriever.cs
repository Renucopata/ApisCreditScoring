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
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            response = JsonConvert.SerializeObject(dt);


                        }

                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

            }



            return response;
        }


        public void GetGbage3(Stream output)
        {
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM general.gbage";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        var reader = command.ExecuteReader();
                        var serializer = new JsonSerializer();

                        using (var writer = new StreamWriter(output))
                        using (var jsonWriter = new JsonTextWriter(writer))
                        {
                            jsonWriter.WriteStartArray();

                            while (reader.Read())
                            {
                                var record = new object[reader.FieldCount];
                                reader.GetValues(record);

                                serializer.Serialize(jsonWriter, record);
                            }

                            jsonWriter.WriteEndArray();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
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
