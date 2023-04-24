using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using Utf8Json;
using MemoryPack;
using ApisCreditScoring.Models;

namespace ApisCreditScoring.Handlers
{


    public class DataRetriever
    {


        public List<GBAGE_RESPONSE> getgbage()
        {
            var responseList = new List<GBAGE_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 5 * FROM general.gbage";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {

                        using (var adapter = new SqlDataAdapter(command))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    var response = new GBAGE_RESPONSE();
                                    response.gbagecage = dt.Rows[i]["gbagecage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbagecage"]) : 0;
                                    response.gbagenomb = Convert.ToString(dt.Rows[i]["gbagenomb"]);
                                    response.gbagetdid = dt.Rows[i]["gbagetdid"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbagetdid"]) : 0;
                                    response.gbagendid = Convert.ToString(dt.Rows[i]["gbagendid"]);
                                    response.gbagenruc = Convert.ToString(dt.Rows[i]["gbagenruc"]);
                                    response.gbagetper = dt.Rows[i]["gbagetper"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbagetper"]) : 0;
                                    response.gbagefnac = Convert.ToString(dt.Rows[i]["gbagefnac"]);
                                    response.gbagesexo = dt.Rows[i]["gbagesexo"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbagesexo"]) : 0;
                                    response.gbageeciv = dt.Rows[i]["gbageeciv"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbageeciv"]) : 0;
                                    response.gbagenaci = Convert.ToString(dt.Rows[i]["gbagenaci"]);
                                    response.gbageprof = dt.Rows[i]["gbageprof"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbageprof"]) : 0;
                                    response.gbagedir1 = Convert.ToString(dt.Rows[i]["gbagedir1"]);
                                    response.gbagedir2 = Convert.ToString(dt.Rows[i]["gbagedir2"]);
                                    response.gbageddo1 = Convert.ToString(dt.Rows[i]["gbageddo1"]);
                                    response.gbageddo2 = Convert.ToString(dt.Rows[i]["gbageddo2"]);
                                    response.gbagetlfd = Convert.ToString(dt.Rows[i]["gbagetlfd"]);
                                    response.gbagetlfo = Convert.ToString(dt.Rows[i]["gbagetlfo"]);
                                    response.gbagencas = Convert.ToString(dt.Rows[i]["gbagencas"]);
                                    response.gbagenfax = Convert.ToString(dt.Rows[i]["gbagenfax"]);
                                    response.gbagetlex = Convert.ToString(dt.Rows[i]["gbagetlex"]);
                                    response.gbageciiu = dt.Rows[i]["gbageciiu"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbageciiu"]) : 0;
                                    response.gbageact1 = Convert.ToString(dt.Rows[i]["gbageact1"]);
                                    response.gbageact2 = Convert.ToString(dt.Rows[i]["gbageact2"]);
                                    response.gbagecalf = Convert.ToString(dt.Rows[i]["gbagecalf"]);
                                    response.gbagefreg = Convert.ToString(dt.Rows[i]["gbagefreg"]);
                                    response.gbageplaz = dt.Rows[i]["gbageplaz"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbageplaz"]) : 0;
                                    response.gbageagen = dt.Rows[i]["gbageagen"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbageagen"]) : 0;
                                    response.gbageuser = Convert.ToString(dt.Rows[i]["gbageuser"]);
                                    response.gbagehora = Convert.ToString(dt.Rows[i]["gbagehora"]);
                                    response.gbagefpro = Convert.ToString(dt.Rows[i]["gbagefpro"]);
                                    response.gbageclas = Convert.ToString(dt.Rows[i]["gbageclas"]);
                                    response.gbagestat = dt.Rows[i]["gbagestat"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbagestat"]) : 0;
                                    response.gbagefsta = Convert.ToString(dt.Rows[i]["gbagefsta"]);
                                    response.gbagestaa = dt.Rows[i]["gbagestaa"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbagestaa"]) : 0;
                                    response.gbageumrc = Convert.ToString(dt.Rows[i]["gbageumrc"]);
                                    response.gbageumod = Convert.ToString(dt.Rows[i]["gbageumod"]);
                                    response.gbagefmod = Convert.ToString(dt.Rows[i]["gbagefmod"]);
                                    response.gbagefmrc = Convert.ToString(dt.Rows[i]["gbagefmrc"]);
                                    response.gbagemrcb = dt.Rows[i]["gbagemrcb"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbagemrcb"]) : 0;
                                    response.gbagecomp = Convert.ToString(dt.Rows[i]["gbagecomp"]);

                                    responseList.Add(response);
                                }

                            }



                        }

                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

            }



            return responseList;
        }


        public List<GBDAC_RESPONSE> getgbdac()
        {
            var responseList = new List<GBDAC_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbdac";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {

                        using (var adapter = new SqlDataAdapter(command))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    var response = new GBDAC_RESPONSE();
                                    response.gbdaccage = dt.Rows[i]["gbdaccage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccage"]) : 0;
                                    response.gbdacnomb = Convert.ToString(dt.Rows[i]["gbdacnomb"]);
                                    response.gbdacape1 = Convert.ToString(dt.Rows[i]["gbdacape1"]);
                                    response.gbdacape2 = Convert.ToString(dt.Rows[i]["gbdacape2"]);
                                    response.gbdacnoco = Convert.ToString(dt.Rows[i]["gbdacnoco"]);
                                    response.gbdaccocl = Convert.ToString(dt.Rows[i]["gbdaccocl"]);
                                    response.gbdacrefp = Convert.ToString(dt.Rows[i]["gbdacrefp"]);
                                    response.gbdacmail = Convert.ToString(dt.Rows[i]["gbdacmail"]);
                                    response.gbdacciud = dt.Rows[i]["gbdacciud"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacciud"]) : 0;
                                    response.gbdacubid = Convert.ToString(dt.Rows[i]["gbdacubid"]);
                                    response.gbdacrefd = Convert.ToString(dt.Rows[i]["gbdacrefd"]);
                                    response.gbdacnemp = Convert.ToString(dt.Rows[i]["gbdacnemp"]);
                                    response.gbdacccar = dt.Rows[i]["gbdacccar"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacccar"]) : 0;
                                    response.gbdacnint = Convert.ToString(dt.Rows[i]["gbdacnint"]);
                                    response.gbdacciuo = dt.Rows[i]["gbdacciuo"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacciuo"]) : 0;
                                    response.gbdacubio = Convert.ToString(dt.Rows[i]["gbdacubio"]);
                                    response.gbdacrefo = Convert.ToString(dt.Rows[i]["gbdacrefo"]);
                                    response.gbdacfing = Convert.ToString(dt.Rows[i]["gbdacfing"]);
                                    response.gbdacrseg = dt.Rows[i]["gbdacrseg"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacrseg"]) : 0;
                                    response.gbdactres = dt.Rows[i]["gbdactres"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdactres"]) : 0;
                                    response.gbdacnori = Convert.ToString(dt.Rows[i]["gbdacnori"]);
                                    response.gbdacfcna = Convert.ToString(dt.Rows[i]["gbdacfcna"]);
                                    response.gbdacflle = dt.Rows[i]["gbdacflle"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacflle"]) : 0;
                                    response.gbdacstat = dt.Rows[i]["gbdacstat"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacstat"]) : 0;
                                    response.gbdacfsta = Convert.ToString(dt.Rows[i]["gbdacfsta"]);
                                    response.gbdacsant = dt.Rows[i]["gbdacsant"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacsant"]) : 0;
                                    response.gbdacfant = Convert.ToString(dt.Rows[i]["gbdacfant"]);
                                    response.gbdaccnac = dt.Rows[i]["gbdaccnac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccnac"]) : 0;
                                    response.gbdacmens = Convert.ToString(dt.Rows[i]["gbdacmens"]);
                                    response.gbdactmen = Convert.ToString(dt.Rows[i]["gbdactmen"]);
                                    response.gbdacneva = Convert.ToString(dt.Rows[i]["gbdacneva"]);
                                    response.gbdacfeva = Convert.ToString(dt.Rows[i]["gbdacfeva"]);
                                    response.gbdaccony = dt.Rows[i]["gbdaccony"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccony"]) : 0;
                                    response.gbdacnive = dt.Rows[i]["gbdacnive"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacnive"]) : 0;
                                    response.gbdaccand = dt.Rows[i]["gbdaccand"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccand"]) : 0;
                                    response.gbdacclfa = Convert.ToString(dt.Rows[i]["gbdacclfa"]);
                                    response.gbdacfcaa = Convert.ToString(dt.Rows[i]["gbdacfcaa"]);
                                    response.gbdacfcal = Convert.ToString(dt.Rows[i]["gbdacfcal"]);
                                    response.gbdacfuad = Convert.ToString(dt.Rows[i]["gbdacfuad"]);
                                    response.gbdaccelu = Convert.ToString(dt.Rows[i]["gbdaccelu"]);
                                    response.gbdacclas = Convert.ToString(dt.Rows[i]["gbdacclas"]);
                                    response.gbdacnom1 = Convert.ToString(dt.Rows[i]["gbdacnom1"]);
                                    response.gbdacnom2 = Convert.ToString(dt.Rows[i]["gbdacnom2"]);
                                    response.gbdacape3 = Convert.ToString(dt.Rows[i]["gbdacape3"]);
                                    response.gbdactmto = Convert.ToString(dt.Rows[i]["gbdactmto"]);
                                    response.gbdaccncn = dt.Rows[i]["gbdaccncn"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccncn"]) : 0;
                                    response.gbdaccnco = dt.Rows[i]["gbdaccnco"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccnco"]) : 0;
                                    response.gbdacpaip = dt.Rows[i]["gbdacpaip"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacpaip"]) : 0;
                                    response.gbdacrubr = dt.Rows[i]["gbdacrubr"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacrubr"]) : 0;
                                    response.gbdacsect = dt.Rows[i]["gbdacsect"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacsect"]) : 0;
                                    response.gbdacactv = dt.Rows[i]["gbdacactv"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacactv"]) : 0;
                                    response.gbdacclsc = dt.Rows[i]["gbdacclsc"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacclsc"]) : 0;
                                    response.gbdactipo = dt.Rows[i]["gbdactipo"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdactipo"]) : 0;
                                    response.gbdacpweb = Convert.ToString(dt.Rows[i]["gbdacpweb"]);
                                    response.gbdacobsv = Convert.ToString(dt.Rows[i]["gbdacobsv"]);
                                    response.gbdacrepr = Convert.ToString(dt.Rows[i]["gbdacrepr"]);
                                    response.gbdaccicl = dt.Rows[i]["gbdaccicl"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccicl"]) : 0;
                                    response.gbdacambg = dt.Rows[i]["gbdacambg"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacambg"]) : 0;
                                    response.gbdacidip = dt.Rows[i]["gbdacidip"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacidip"]) : 0;
                                    response.gbdacidis = dt.Rows[i]["gbdacidis"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacidis"]) : 0;
                                    response.gbdacciun = dt.Rows[i]["gbdacciun"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacciun"]) : 0;
                                    response.gbdacpeso = dt.Rows[i]["gbdacpeso"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacpeso"]) : 0;
                                    response.gbdacestt = dt.Rows[i]["gbdacestt"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacestt"]) : 0;
                                    response.gbdacfmat = Convert.ToString(dt.Rows[i]["gbdacfmat"]);
                                    response.gbdacnfam = dt.Rows[i]["gbdacnfam"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacnfam"]) : 0;
                                    response.gbdaccalp = dt.Rows[i]["gbdaccalp"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccalp"]) : 0;
                                    response.gbdaclact = dt.Rows[i]["gbdaclact"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaclact"]) : 0;
                                    response.gbdacfiac = Convert.ToString(dt.Rows[i]["gbdacfiac"]);
                                    response.gbdactaac = dt.Rows[i]["gbdactaac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdactaac"]) : 0;
                                    response.gbdactmac = dt.Rows[i]["gbdactmac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdactmac"]) : 0;
                                    response.gbdactdac = dt.Rows[i]["gbdactdac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdactdac"]) : 0;
                                    response.gbdacidac = dt.Rows[i]["gbdacidac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacidac"]) : 0;
                                    response.gbdacdisc = Convert.ToString(dt.Rows[i]["gbdacdisc"]);
                                    response.gbdactdis = dt.Rows[i]["gbdactdis"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdactdis"]) : 0;


                                    responseList.Add(response);
                                }

                            }



                        }

                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

            }



            return responseList;
        }

        public List<GBDBI_RESPONSE> getgbdbi()
        {
            var responseList = new List<GBDBI_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbdbi";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {

                        using (var adapter = new SqlDataAdapter(command))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    var response = new GBDBI_RESPONSE();
                                    response.gbdbicage = dt.Rows[i]["gbdbicage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbicage"]) : 0;
                                    var aux = Convert.ToDateTime(dt.Rows[i]["gbdbifech"]);
                                    response.gbdbifech = aux.ToString("yyyy-MM-dd");
                                    response.gbdbicmon = dt.Rows[i]["gbdbicmon"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbicmon"]) : 0;
                                    response.gbdbitviv = Convert.ToString(dt.Rows[i]["gbdbitviv"]);
                                    response.gbdbiaemp = dt.Rows[i]["gbdbiaemp"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbiaemp"]) : 0;
                                    response.gbdbiifij = dt.Rows[i]["gbdbiifij"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbiifij"]) : 0;
                                    response.gbdbiivar = dt.Rows[i]["gbdbiivar"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbiivar"]) : 0;
                                    response.gbdbigfij = dt.Rows[i]["gbdbigfij"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbigfij"]) : 0;
                                    response.gbdbigvar = dt.Rows[i]["gbdbigvar"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbigvar"]) : 0;
                                    response.gbdbitact = dt.Rows[i]["gbdbitact"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbitact"]) : 0;
                                    response.gbdbitpas = dt.Rows[i]["gbdbitpas"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbitpas"]) : 0;
                                    response.gbdbipatr = dt.Rows[i]["gbdbipatr"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbipatr"]) : 0;
                                    response.gbdbiisal = Convert.ToString(dt.Rows[i]["gbdbiisal"]);
                                    response.gbdbiporc = dt.Rows[i]["gbdbiporc"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbiporc"]) : 0;
                                    response.gbdbitotv = dt.Rows[i]["gbdbitotv"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbitotv"]) : 0;
                                    response.gbdbicper = dt.Rows[i]["gbdbitotv"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbitotv"]) : 0;
                                    response.gbdbiinde = dt.Rows[i]["gbdbitotv"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbitotv"]) : 0;
                                    response.gbdbitpre = dt.Rows[i]["gbdbitotv"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbitotv"]) : 0;
                                    response.gbdbiciiu = dt.Rows[i]["gbdbiciiu"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbiciiu"]) : 0;
                                    response.gbdbicate = Convert.ToString(dt.Rows[i]["gbdbicate"]);
                                    response.gbdbiscii = Convert.ToString(dt.Rows[i]["gbdbiscii"]);
                                    response.gbdbitcof = dt.Rows[i]["gbdbitcof"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbitcof"]) : 0;
                                    response.gbdbicapa = dt.Rows[i]["gbdbicapa"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdbicapa"]) : 0;
                                    response.gbdbiuser = Convert.ToString(dt.Rows[i]["gbdbiuser"]);
                                    response.gbdbihora = Convert.ToString(dt.Rows[i]["gbdbihora"]);
                                    var aux2 = Convert.ToDateTime(dt.Rows[i]["gbdbifpro"]);
                                    response.gbdbifpro = aux.ToString("yyyy-MM-dd");

                                 


                                    responseList.Add(response);
                                }

                            }



                        }

                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

            }



            return responseList;
        }


        /* public void GetGbage3(Stream output)
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
         }*/

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
