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

        public List<GBAEC_RESPONSE> getGbaec()
        {
            var responseList = new List<GBAEC_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM gbaec";
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
                                    var response = new GBAEC_RESPONSE();
                                    response.gbaeccage = dt.Rows[i]["gbaeccage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbaeccage"]) : 0;
                                    response.gbaeccaec = dt.Rows[i]["gbaeccaec"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbaeccaec"]) : 0;
                                    response.gbaecfreg = Convert.ToDateTime(dt.Rows[i]["gbaecfreg"]);
                                    response.gbaecdesc = Convert.ToString(dt.Rows[i]["gbaecdesc"]);
                                    response.gbaecisec = dt.Rows[i]["gbaecisec"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbaecisec"]) : 0;
                                    response.gbaecmrcb = dt.Rows[i]["gbaecmrcb"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbaecmrcb"]) : 0;;
                                    response.gbaecmusr = Convert.ToString(dt.Rows[i]["gbaecmusr"]);
                                    response.gbaecmhor = Convert.ToString(dt.Rows[i]["gbaecmhor"]);
                                    response.gbaecmfec = Convert.ToDateTime(dt.Rows[i]["gbaecmfec"]);
                                    response.gbaecusrn = Convert.ToString(dt.Rows[i]["gbaecusrn"]);
                                    response.gbaechora = Convert.ToString(dt.Rows[i]["gbaechora"]);
                                    response.gbaecfpro = Convert.ToDateTime(dt.Rows[i]["gbaecfpro"]);
                                

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



        public List<GBAGE_RESPONSE> getgbage()
        {
            var responseList = new List<GBAGE_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 200 * FROM general.gbage";
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
                                    response.gbagefsaa = Convert.ToString(dt.Rows[i]["gbagefsaa"]);
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


        public List<GBBEN_RESPONSE> getGbben()
        {
            var responseList = new List<GBBEN_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM gbben";
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
                                    var response = new GBBEN_RESPONSE();
                                    response.gbbencage = dt.Rows[i]["gbbencage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbbencage"]) : 0;
                                    response.gbbentseg = dt.Rows[i]["gbbentseg"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbbentseg"]) : 0;
                                    response.gbbenpate = Convert.ToString(dt.Rows[i]["gbbenpate"]);
                                    response.gbbenmate = Convert.ToString(dt.Rows[i]["gbbenmate"]);
                                    response.gbbennom1 = Convert.ToString(dt.Rows[i]["gbbennom1"]);
                                    response.gbbennom2 = Convert.ToString(dt.Rows[i]["gbbennom2"]);
                                    response.gbbenndid = Convert.ToString(dt.Rows[i]["gbbenndid"]);
                                    response.gbbenpare = dt.Rows[i]["gbbenpare"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbbenpare"]) : 0;
                                    response.gbbenpart = dt.Rows[i]["gbbenpart"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbbenpart"]) : 0;

                              


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


        public List<GBCPO_RESPONSE> getGbcpo()
        {
            var responseList = new List<GBCPO_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM gbcpo";
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
                                    var response = new GBCPO_RESPONSE();
                                    response.gbcpocage = dt.Rows[i]["gbcpocage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbcpocage"]) : 0;
                                    response.gbcpofino = Convert.ToDateTime(dt.Rows[i]["gbcpofino"]);
                                    response.gbcponmod = dt.Rows[i]["gbcponmod"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbcponmod"]) : 0; ;
                                    response.gbcpooper = dt.Rows[i]["gbcpooper"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbcpooper"]) : 0;
                                    response.gbcpocodb = dt.Rows[i]["gbcpocodb"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbcpocodb"]) : 0;
                                    response.gbcpootro = Convert.ToString(dt.Rows[i]["gbcpootro"]);
                                    response.gbcpobeni = dt.Rows[i]["gbcpobeni"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbcpobeni"]) : 0;
                                    response.gbcpofini = Convert.ToDateTime(dt.Rows[i]["gbcpofini"]);
                                    response.gbcpouser = Convert.ToString(dt.Rows[i]["gbcpouser"]);
                                    response.gbcpohora = Convert.ToString(dt.Rows[i]["gbcpohora"]);
                                    response.gbcpofpro = Convert.ToDateTime(dt.Rows[i]["gbcpofpro"]);

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

        public List<GBCSF_RESPONSE> getGbcsf()
        {
            var responseList = new List<GBCSF_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM gbcsf";
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
                                    var response = new GBCSF_RESPONSE();
                                    response.gbcsfdpto = dt.Rows[i]["gbcsfdpto"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbcsfdpto"]) : 0;
                                    response.gbcsfciud = Convert.ToString(dt.Rows[i]["gbcsfciud"]);
                                    response.gbcsfdpt1 = Convert.ToString(dt.Rows[i]["gbcsfdpt1"]);
                                    response.gbcsfdesc = Convert.ToString(dt.Rows[i]["gbcsfdesc"]);
                                    response.gbcsfprov = Convert.ToString(dt.Rows[i]["gbcsfprov"]);
                                    response.gbcsfsecc = Convert.ToString(dt.Rows[i]["gbcsfsecc"]);
                                    response.gbcsfcant = Convert.ToString(dt.Rows[i]["gbcsfcant"]);

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


        public List<GBDAC_H_RESPONSE> getGbdac_h()
        {
            var responseList = new List<GBDAC_H_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbdac_h";
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
                                    var response = new GBDAC_H_RESPONSE();
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
                                    response.gbdacfing = Convert.ToDateTime(dt.Rows[i]["gbdacfing"]);
                                    response.gbdacrseg = dt.Rows[i]["gbdacrseg"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacrseg"]) : 0;
                                    response.gbdactres = dt.Rows[i]["gbdactres"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdactres"]) : 0;
                                    response.gbdacnori = Convert.ToString(dt.Rows[i]["gbdacnori"]);
                                    response.gbdacfcna = Convert.ToDateTime(dt.Rows[i]["gbdacfcna"]);
                                    response.gbdacflle = dt.Rows[i]["gbdacflle"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacflle"]) : 0;
                                    response.gbdacstat = dt.Rows[i]["gbdacstat"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacstat"]) : 0;
                                    response.gbdacfsta = Convert.ToDateTime(dt.Rows[i]["gbdacfsta"]);
                                    response.gbdacsant = dt.Rows[i]["gbdacsant"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacsant"]) : 0;
                                    response.gbdacfant = Convert.ToDateTime(dt.Rows[i]["gbdacfant"]);
                                    response.gbdaccnac = dt.Rows[i]["gbdaccnac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccnac"]) : 0;
                                    response.gbdacmens = Convert.ToString(dt.Rows[i]["gbdacmens"]);
                                    response.gbdactmen = Convert.ToString(dt.Rows[i]["gbdactmen"]);
                                    response.gbdacneva = Convert.ToString(dt.Rows[i]["gbdacneva"]);
                                    response.gbdacfeva = Convert.ToDateTime(dt.Rows[i]["gbdacfeva"]);
                                    response.gbdaccony = dt.Rows[i]["gbdaccony"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccony"]) : 0;
                                    response.gbdacnive = dt.Rows[i]["gbdacnive"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacnive"]) : 0;
                                    response.gbdaccand = dt.Rows[i]["gbdaccand"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccand"]) : 0;
                                    response.gbdacclfa = Convert.ToString(dt.Rows[i]["gbdacclfa"]);
                                    response.gbdacfcaa = Convert.ToDateTime(dt.Rows[i]["gbdacfcaa"]);
                                    response.gbdacfcal = Convert.ToDateTime(dt.Rows[i]["gbdacfcal"]);
                                    response.gbdacfuad = Convert.ToDateTime(dt.Rows[i]["gbdacfuad"]);
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
                                    response.gbdacfmat = Convert.ToDateTime(dt.Rows[i]["gbdacfmat"]);
                                    response.gbdacnfam = dt.Rows[i]["gbdacnfam"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacnfam"]) : 0;
                                    response.gbdaccalp = dt.Rows[i]["gbdaccalp"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaccalp"]) : 0;
                                    response.gbdaclact = dt.Rows[i]["gbdaclact"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdaclact"]) : 0;
                                    response.gbdacfiac = Convert.ToDateTime(dt.Rows[i]["gbdacfiac"]);
                                    response.gbdactaac = dt.Rows[i]["gbdactaac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdactaac"]) : 0;
                                    response.gbdactmac = dt.Rows[i]["gbdactmac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdactmac"]) : 0;
                                    response.gbdactdac = dt.Rows[i]["gbdactdac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdactdac"]) : 0;
                                    response.gbdacidac = dt.Rows[i]["gbdacidac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdacidac"]) : 0;
                                    response.gbdacusrl = Convert.ToString(dt.Rows[i]["gbdacusrl"]);
                                    response.gbdacdate = Convert.ToString(dt.Rows[i]["gbdacdate"]);
                                    response.gbdacevto = Convert.ToString(dt.Rows[i]["gbdacevto"]);



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


        public List<GBDEU_RESPONSE> getGbdeu()
        {
            var responseList = new List<GBDEU_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbdeu";
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
                                    var response = new GBDEU_RESPONSE();
                                    response.gbdeucage = dt.Rows[i]["gbdeucage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdeucage"]) : 0;
                                    response.gbdeuimpt = dt.Rows[i]["gbdeuimpt"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbdeuimpt"]) : 0;
                                    response.gbdeucmon = dt.Rows[i]["gbdeucmon"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdeucmon"]) : 0;
                                    response.gbdeutdeu = dt.Rows[i]["gbdeutdeu"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbdeutdeu"]) : 0;
                                    response.gbdeutotd = dt.Rows[i]["gbdeutotd"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbdeutotd"]) : 0;
                                    response.gbdeufech = Convert.ToDateTime(dt.Rows[i]["gbdeufech"]);
                                    response.gbdeugara = dt.Rows[i]["gbdeugara"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbdeugara"]) : 0;
                                    response.gbdeugarl = dt.Rows[i]["gbdeugarl"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbdeugarl"]) : 0;
                                   
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

        public List<GBDGO_RESPONSE> getGbdgo()
        {
            var responseList = new List<GBDGO_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbdgo";
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
                                    var response = new GBDGO_RESPONSE();
                                    response.gbdgonsol = dt.Rows[i]["gbdgonsol"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgonsol"]) : 0; 
                                    response.gbdgocage = dt.Rows[i]["gbdgocage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgocage"]) : 0;
                                    response.gbdgofreg = Convert.ToDateTime(dt.Rows[i]["gbdgofreg"]);
                                    response.gbdgocins = dt.Rows[i]["gbdgocins"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgocins"]) : 0;
                                    response.gbdgonopr = Convert.ToString(dt.Rows[i]["gbdgonopr"]);
                                    response.gbdgocalf = Convert.ToString(dt.Rows[i]["gbdgocalf"]);
                                    response.gbdgodest = dt.Rows[i]["gbdgodest"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgodest"]) : 0;
                                    response.gbdgostat = dt.Rows[i]["gbdgostat"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgostat"]) : 0;
                                    response.gbdgocmon = dt.Rows[i]["gbdgocmon"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgocmon"]) : 0;
                                    response.gbdgocuom = dt.Rows[i]["gbdgocuom"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbdgocuom"]) : 0;
                                    response.gbdgoncuo = dt.Rows[i]["gbdgoncuo"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgoncuo"]) : 0;
                                    response.gbdgoncup = dt.Rows[i]["gbdgoncup"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgoncup"]) : 0;
                                    response.gbdgoplzo = dt.Rows[i]["gbdgoplzo"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgoplzo"]) : 0;
                                    response.gbdgomont = dt.Rows[i]["gbdgomont"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbdgomont"]) : 0;
                                    response.gbdgomdes = dt.Rows[i]["gbdgomdes"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbdgomdes"]) : 0;
                                    response.gbdgotdeu = dt.Rows[i]["gbdgotdeu"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgotdeu"]) : 0;
                                    response.gbdgofech = Convert.ToDateTime(dt.Rows[i]["gbdgofech"]);
                                    response.gbdgottas = dt.Rows[i]["gbdgottas"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgottas"]) : 0;
                                    response.gbdgotasa = Convert.ToString(dt.Rows[i]["gbdgotasa"]);
                                    response.gbdgotdei = dt.Rows[i]["gbdgotdei"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgotdei"]) : 0;
                                    response.gbdgotres = dt.Rows[i]["gbdgotres"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdgotres"]) : 0;
                                    response.gbdgousrn = Convert.ToString(dt.Rows[i]["gbdgousrn"]);
                                    response.gbdgohora = Convert.ToString(dt.Rows[i]["gbdgohora"]);
                                    response.gbdgofpro = Convert.ToDateTime(dt.Rows[i]["gbdgofpro"]);

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

        public List<GBDIC_RESPONSE> getGbdic()
        {
            var responseList = new List<GBDIC_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbdic";
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
                                    var response = new GBDIC_RESPONSE();
                                    response.gbdiccage = dt.Rows[i]["gbdiccage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccage"]) : 0;
                                    response.gbdicfreg = Convert.ToDateTime(dt.Rows[i]["gbdicfreg"]);

                                    response.gbdicidir = dt.Rows[i]["gbdicidir"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdicidir"]) : 0;
                                    response.gbdiccdep = dt.Rows[i]["gbdiccdep"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccdep"]) : 0;
                                    response.gbdiccobr = dt.Rows[i]["gbdiccobr"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccobr"]) : 0;
                                    response.gbdiccpro = dt.Rows[i]["gbdiccpro"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccpro"]) : 0;
                                    response.gbdicheda = dt.Rows[i]["gbdicheda"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdicheda"]) : 0;
                                    response.gbdichned = dt.Rows[i]["gbdichned"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdichned"]) : 0;
                                    response.gbdictres = dt.Rows[i]["gbdictres"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbdictres"]) : 0;
                                    response.gbdictten = dt.Rows[i]["gbdictten"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdictten"]) : 0;
                                    response.gbdictviv = dt.Rows[i]["gbdictviv"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdictviv"]) : 0;
                                    response.gbdicdviv = Convert.ToString(dt.Rows[i]["gbdicdviv"]);
                                    response.gbdictpar = dt.Rows[i]["gbdictpar"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdictpar"]) : 0;
                                    response.gbdictpis = dt.Rows[i]["gbdictpis"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdictpis"]) : 0;
                                    response.gbdicttec = dt.Rows[i]["gbdicttec"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdicttec"]) : 0;
                                    response.gbdicsagu = Convert.ToString(dt.Rows[i]["gbdicsagu"]);
                                    response.gbdicsluz = Convert.ToString(dt.Rows[i]["gbdicsluz"]);
                                    response.gbdicsalc = Convert.ToString(dt.Rows[i]["gbdicsalc"]);
                                    response.gbdicstlf = Convert.ToString(dt.Rows[i]["gbdicstlf"]);
                                    response.gbdicstce = Convert.ToString(dt.Rows[i]["gbdicstce"]);
                                    response.gbdicpavi = Convert.ToString(dt.Rows[i]["gbdicpavi"]);
                                    response.gbdiccocu = dt.Rows[i]["gbdiccocu"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccocu"]) : 0;
                                    response.gbdicccto = dt.Rows[i]["gbdicccto"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdicccto"]) : 0;
                                    response.gbdiccbno = dt.Rows[i]["gbdiccbno"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccbno"]) : 0;
                                    response.gbdiccduc = dt.Rows[i]["gbdiccduc"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccduc"]) : 0;
                                    response.gbdiccref = dt.Rows[i]["gbdiccref"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccref"]) : 0;
                                    response.gbdicctel = dt.Rows[i]["gbdicctel"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdicctel"]) : 0;
                                    response.gbdiccdvd = dt.Rows[i]["gbdiccdvd"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccdvd"]) : 0;
                                    response.gbdiccmes = dt.Rows[i]["gbdiccmes"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccmes"]) : 0;
                                    response.gbdiccveh = dt.Rows[i]["gbdiccveh"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccveh"]) : 0;
                                    response.gbdiccoce = Convert.ToString(dt.Rows[i]["gbdiccoce"]);
                                    response.gbdiccmbc = dt.Rows[i]["gbdiccmbc"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdiccmbc"]) : 0;
                                    response.gbdicrdrr = Convert.ToString(dt.Rows[i]["gbdicrdrr"]);
                                    response.gbdicmtrf = Convert.ToString(dt.Rows[i]["gbdicmtrf"]);
                                    response.gbdicodoc = Convert.ToString(dt.Rows[i]["gbdicodoc"]);
                                    response.gbdicddoc = Convert.ToString(dt.Rows[i]["gbdicddoc"]);
                                    response.gbdicario = Convert.ToString(dt.Rows[i]["gbdicario"]);
                                    response.gbdicamnt = Convert.ToString(dt.Rows[i]["gbdicamnt"]);
                                    response.gbdicabot = Convert.ToString(dt.Rows[i]["gbdicabot"]);
                                    response.gbdicafab = Convert.ToString(dt.Rows[i]["gbdicafab"]);
                                    response.gbdicaotr = Convert.ToString(dt.Rows[i]["gbdicaotr"]);
                                    response.gbdicscul = Convert.ToString(dt.Rows[i]["gbdicscul"]);
                                    response.gbdicuser = Convert.ToString(dt.Rows[i]["gbdicuser"]);
                                    response.gbdichora = Convert.ToString(dt.Rows[i]["gbdichora"]);
                                    response.gbdicfpro = Convert.ToDateTime(dt.Rows[i]["gbdicfpro"]);
                                    response.gbdicnhij = dt.Rows[i]["gbdicnhij"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdicnhij"]) : 0;
                                    response.gbdicsgdo = Convert.ToString(dt.Rows[i]["gbdicsgdo"]);
                                    response.gbdicceso = dt.Rows[i]["gbdicceso"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdicceso"]) : 0;
                                    response.gbdicglos = Convert.ToString(dt.Rows[i]["gbdicglos"]);
                                    response.gbdicnmat = Convert.ToString(dt.Rows[i]["gbdicnmat"]);
                                    response.gbdicspro = dt.Rows[i]["gbdicspro"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbdicspro"]) : 0;
                                    response.gbdicunid = dt.Rows[i]["gbdicunid"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdicunid"]) : 0;
                                    

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

        public List<GBDOC_H_RESPONSE> getGbdoc_h()
        {
            var responseList = new List<GBDOC_H_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbdoc_h";
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
                                    var response = new GBDOC_H_RESPONSE();
                                    response.gbdoccage = dt.Rows[i]["gbdoccage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdoccage"]) : 0;
                                    response.gbdocndid = Convert.ToString(dt.Rows[i]["gbdocndid"]);
                                    response.gbdocfvid = Convert.ToDateTime(dt.Rows[i]["gbdocfvid"]);
                                    response.gbdocnruc = Convert.ToString(dt.Rows[i]["gbdocnruc"]);
                                    response.gbdocfvru = Convert.ToDateTime(dt.Rows[i]["gbdocfvru"]);
                                    response.gbdocfreg = Convert.ToDateTime(dt.Rows[i]["gbdocfreg"]);
                                    response.gbdocplaz = dt.Rows[i]["gbdocplaz"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdocplaz"]) : 0;
                                    response.gbdocagen = dt.Rows[i]["gbdocagen"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbdocagen"]) : 0;
                                    response.gbdocuser = Convert.ToString(dt.Rows[i]["gbdocuser"]);
                                    response.gbdochora = Convert.ToString(dt.Rows[i]["gbdochora"]);
                                    response.gbdocfpro = Convert.ToDateTime(dt.Rows[i]["gbdocfpro"]);
                                    response.gbdocusrl = Convert.ToString(dt.Rows[i]["gbdocusrl"]);
                                    response.gbdocdate = Convert.ToString(dt.Rows[i]["gbdocdate"]);
                                    response.gbdocevto = Convert.ToString(dt.Rows[i]["gbdocevto"]);

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

        public List<GBEMA_RESPONSE> getGbema()
        {
            var responseList = new List<GBEMA_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbema";
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
                                    var response = new GBEMA_RESPONSE();
                                    response.gbemacage = dt.Rows[i]["gbemacage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbemacage"]) : 0;
                                    response.gbemaitem = dt.Rows[i]["gbemaitem"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbemaitem"]) : 0;
                                    response.gbemamail = Convert.ToString(dt.Rows[i]["gbemamail"]);
                                    response.gbemamrpi = dt.Rows[i]["gbemamrpi"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbemamrpi"]) : 0;
                                    response.gbemamrcb = dt.Rows[i]["gbemamrcb"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbemamrcb"]) : 0;

                                    response.gbemafmrc = Convert.ToDateTime(dt.Rows[i]["gbemafmrc"]);
                                    response.gbemauser = Convert.ToString(dt.Rows[i]["gbemauser"]);
                                    response.gbemahora = Convert.ToString(dt.Rows[i]["gbemahora"]);
                                    response.gbemafpro = Convert.ToDateTime(dt.Rows[i]["gbemafpro"]);
                                   

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

        public List<GBHCA_RESPONSE> getGbhca()
        {
            var responseList = new List<GBHCA_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbhca";
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
                                    var response = new GBHCA_RESPONSE();
                                    response.gbhcafreg = Convert.ToDateTime(dt.Rows[i]["gbhcafreg"]);
                                    response.gbhcatcal = dt.Rows[i]["gbhcatcal"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhcatcal"]) : 0;
                                    response.gbhcamodn = dt.Rows[i]["gbhcamodn"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhcamodn"]) : 0;
                                    response.gbhcanopr = dt.Rows[i]["gbhcanopr"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhcanopr"]) : 0;
                                    response.gbhcacage = dt.Rows[i]["gbhcacage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhcacage"]) : 0;


                                    response.gbhcacalf = Convert.ToString(dt.Rows[i]["gbhcacalf"]);
                                    response.gbhcaclfa = Convert.ToString(dt.Rows[i]["gbhcaclfa"]);

                                    response.gbhcappgk = dt.Rows[i]["gbhcappgk"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhcappgk"]) : 0;
                                    response.gbhcacmon = dt.Rows[i]["gbhcacmon"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhcacmon"]) : 0;

                                    response.gbhcasald = dt.Rows[i]["gbhcasald"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhcasald"]) : 0;
                                    response.gbhcaendt = dt.Rows[i]["gbhcaendt"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhcaendt"]) : 0;
                                    response.gbhcastat = dt.Rows[i]["gbhcastat"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhcastat"]) : 0;


                                    response.gbhcafpvc = Convert.ToDateTime(dt.Rows[i]["gbhcafpvc"]);
                                    response.gbhcadias = dt.Rows[i]["gbhcadias"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhcadias"]) : 0;

                                    response.gbhcabipn = Convert.ToString(dt.Rows[i]["gbhcabipn"]);
                                    response.gbhcaglos = Convert.ToString(dt.Rows[i]["gbhcaglos"]);
                                    response.gbhcauser = Convert.ToString(dt.Rows[i]["gbhcauser"]);
                                    response.gbhcahora = Convert.ToString(dt.Rows[i]["gbhcahora"]);

                                    response.gbhcafpro = Convert.ToDateTime(dt.Rows[i]["gbhcafpro"]);

                                    response.gbhcacclf = dt.Rows[i]["gbhcacclf"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhcacclf"]) : 0;
                                    response.gbhcacpac = dt.Rows[i]["gbhcacpac"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhcacpac"]) : 0;


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

        public List<GBHPR_RESPONSE> getGbhpr()
        {
            var responseList = new List<GBHPR_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbhpr";
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
                                    var response = new GBHPR_RESPONSE();
                                    response.gbhprcage = dt.Rows[i]["gbhprcage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhprcage"]) : 0;
                                    response.gbhprcpre = dt.Rows[i]["gbhprcpre"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhprcpre"]) : 0;
                                    response.gbhprcfun = dt.Rows[i]["gbhprcfun"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhprcfun"]) : 0;
                                    response.gbhprmdes = dt.Rows[i]["gbhprmdes"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhprmdes"]) : 0;

                                    response.gbhprcmon = dt.Rows[i]["gbhprcmon"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhprcmon"]) : 0;
                                    response.gbhprtasa = Convert.ToString(dt.Rows[i]["gbhprtasa"]);

                                    response.gbhprdmor = dt.Rows[i]["gbhprdmor"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhprdmor"]) : 0;
                                    response.gbhprcpen = dt.Rows[i]["gbhprcpen"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhprcpen"]) : 0;
                                    

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

        public List<GBHSV_RESPONSE> getGbhsv()
        {
            var responseList = new List<GBHSV_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbhsv";
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
                                    var response = new GBHSV_RESPONSE();
                                    response.gbhsvnmod = dt.Rows[i]["gbhsvnmod"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhsvnmod"]) : 0;
                                    response.gbhsvtipo = dt.Rows[i]["gbhsvtipo"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhsvtipo"]) : 0;
                                    response.gbhsvnopr = dt.Rows[i]["gbhsvnopr"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhsvnopr"]) : 0;
                                    response.gbhsvcarg = dt.Rows[i]["gbhsvcarg"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhsvcarg"]) : 0;
                                    response.gbhsvcmon = dt.Rows[i]["gbhsvcmon"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhsvcmon"]) : 0;
                                    response.gbhsvmont = dt.Rows[i]["gbhsvmont"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhsvmont"]) : 0;

                                    response.gbhsvfech = Convert.ToDateTime(dt.Rows[i]["gbhsvfech"]);
                                    response.gbhsvfupg = Convert.ToDateTime(dt.Rows[i]["gbhsvfupg"]);
                                    response.gbhsvfpvc = Convert.ToDateTime(dt.Rows[i]["gbhsvfpvc"]);

                                    response.gbhsvsald = dt.Rows[i]["gbhsvsald"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhsvsald"]) : 0;
                                    response.gbhsvmrcb = dt.Rows[i]["gbhsvmrcb"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhsvmrcb"]) : 0;
                                    response.gbhsvplaz = dt.Rows[i]["gbhsvplaz"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhsvplaz"]) : 0;
                                    response.gbhsvagen = dt.Rows[i]["gbhsvagen"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhsvagen"]) : 0;


                                    response.gbhsvuser = Convert.ToString(dt.Rows[i]["gbhsvuser"]);
                                    response.gbhsvhora = Convert.ToString(dt.Rows[i]["gbhsvhora"]);
                                    response.gbhsvfpro = Convert.ToDateTime(dt.Rows[i]["gbhsvfpro"]);

                                    response.gbhsvbien = dt.Rows[i]["gbhsvbien"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhsvbien"]) : 0;
                                    response.gbhsvcage = dt.Rows[i]["gbhsvcage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhsvcage"]) : 0;
                                    response.gbhsvtman = dt.Rows[i]["gbhsvtman"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhsvtman"]) : 0;
                                    response.gbhsvcalf = dt.Rows[i]["gbhsvcalf"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhsvcalf"]) : 0;
                                    response.gbhsvclas = Convert.ToString(dt.Rows[i]["gbhsvclas"]);
                                    response.gbhsvstat = dt.Rows[i]["gbhsvstat"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhsvstat"]) : 0;


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

        public List<GBHTR_RESPONSE> getGbhtr()
        {
            var responseList = new List<GBHTR_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbhtr";
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
                                    var response = new GBHTR_RESPONSE();
                                    response.gbhtrntra = dt.Rows[i]["gbhtrntra"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhtrntra"]) : 0;
                                    response.gbhtrcage = dt.Rows[i]["gbhtrcage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhtrcage"]) : 0;

                                    response.gbhtrftra = Convert.ToDateTime(dt.Rows[i]["gbhtrftra"]);
                                    response.gbhtrfdev = Convert.ToDateTime(dt.Rows[i]["gbhtrfdev"]);
                                    response.gbhtrcmnt = Convert.ToString(dt.Rows[i]["gbhtrcmnt"]);
                                    response.gbhtrcmnd = Convert.ToString(dt.Rows[i]["gbhtrcmnd"]);

                                    response.gbhtriare = dt.Rows[i]["gbhtriare"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhtriare"]) : 0;
                                    response.gbhtriret = dt.Rows[i]["gbhtriret"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhtriret"]) : 0;
                                    response.gbhtrcmon = dt.Rows[i]["gbhtrcmon"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhtrcmon"]) : 0;
                          
                                    response.gbhtrcfrt = dt.Rows[i]["gbhtrcfrt"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhtrcfrt"]) : 0;
                                    response.gbhtrtcfr = dt.Rows[i]["gbhtrtcfr"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhtrtcfr"]) : 0;
                                    response.gbhtrcfdv = dt.Rows[i]["gbhtrcfdv"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhtrcfdv"]) : 0;
                                    response.gbhtrtcfd = dt.Rows[i]["gbhtrtcfd"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhtrtcfd"]) : 0;
                                    response.gbhtrscgs = dt.Rows[i]["gbhtrscgs"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhtrscgs"]) : 0;
                                    response.gbhtrsret = dt.Rows[i]["gbhtrsret"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["gbhtrsret"]) : 0;
                    
                                    response.gbhtruser = Convert.ToString(dt.Rows[i]["gbhtruser"]);
                                    response.gbhtrhora = Convert.ToString(dt.Rows[i]["gbhtrhora"]);
                                    response.gbhtrfpro = Convert.ToDateTime(dt.Rows[i]["gbhtrfpro"]);

                                    response.gbhtrusrd = Convert.ToString(dt.Rows[i]["gbhtrusrd"]);
                                    response.gbhtrhrad = Convert.ToString(dt.Rows[i]["gbhtrhrad"]);
                                    response.gbhtrfchd = Convert.ToDateTime(dt.Rows[i]["gbhtrfchd"]);

                                    response.gbhtrplaz = dt.Rows[i]["gbhtrplaz"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhtrplaz"]) : 0;
                                    response.gbhtragen = dt.Rows[i]["gbhtragen"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbhtragen"]) : 0;
                                    
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


        public List<GBPRC_RESPONSE> getGbprc()
        {
            var responseList = new List<GBPRC_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbprc";
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
                                    var response = new GBPRC_RESPONSE();

                                    response.gbprcgrup = Convert.ToString(dt.Rows[i]["gbprcgrup"]);
                                    response.gbprcdesc = Convert.ToString(dt.Rows[i]["gbprcdesc"]);

                                    response.gbprcnive = dt.Rows[i]["gbprcnive"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbprcnive"]) : 0;
                                    response.gbprcprof = dt.Rows[i]["gbprcprof"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbprcprof"]) : 0;
                                    

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


        public List<GBPRF_RESPONSE> getGbprf()
        {
            var responseList = new List<GBPRF_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbprf";
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
                                    var response = new GBPRF_RESPONSE();

                                    response.gbprfprof = dt.Rows[i]["gbprfprof"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbprfprof"]) : 0;
                                    response.gbprfdesc = Convert.ToString(dt.Rows[i]["gbprfdesc"]);
                                    response.gbprfabre = Convert.ToString(dt.Rows[i]["gbprfabre"]);

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

        public List<GBPTE_RESPONSE> getGbpte()
        {
            var responseList = new List<GBPTE_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM general.gbpte";
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
                                    var response = new GBPTE_RESPONSE();

                                    response.gbptetemp = dt.Rows[i]["gbptetemp"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["gbptetemp"]) : 0;
                                    response.gbpteinde = Convert.ToString(dt.Rows[i]["gbpteinde"]);

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


        //Prestamos comerciales methods-----

        public List<PRAUT_RESPONSE> getPraut() 
        {
            var responseList = new List<PRAUT_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM praut";
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
                                    var response = new PRAUT_RESPONSE();
                                    response.prautnaut = dt.Rows[i]["prautnaut"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prautnaut"]) : 0;
                                    response.prautusau = Convert.ToString(dt.Rows[i]["prautusau"]);
                                    response.prautfeau = Convert.ToDateTime(dt.Rows[i]["prautfeau"]);
                                    response.prauthoau = Convert.ToString(dt.Rows[i]["prauthoau"]);
                                    response.prautusso = Convert.ToString(dt.Rows[i]["prautusso"]);
                                    response.prautagso = Convert.ToString(dt.Rows[i]["prautagso"]);


                                    
                                    response.prautplso = dt.Rows[i]["prautplso"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prautplso"]) : 0;
                                    response.prautfeso = Convert.ToDateTime(dt.Rows[i]["prautfeso"]);
                                    response.prauthoso = Convert.ToString(dt.Rows[i]["prauthoso"]);
                                    response.prautttrn = dt.Rows[i]["prdeutres"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prautttrn"]) : 0;
                                    response.prauttipo = dt.Rows[i]["prauttipo"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prauttipo"]) : 0;
                                    response.prautcage = dt.Rows[i]["prautcage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prautcage"]) : 0;
                                    response.prautftra = Convert.ToDateTime(dt.Rows[i]["prautftra"]);
                                    response.prautfvto = Convert.ToDateTime(dt.Rows[i]["prautfvto"]);
                                    response.prautimpt = dt.Rows[i]["prautimpt"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["prautimpt"]) : 0;
                                    response.prautcmon = dt.Rows[i]["prautcmon"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prautcmon"]) : 0;
                                    response.prautnpre = dt.Rows[i]["prautnpre"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["prautnpre"]) : 0;
                                    response.prautstat = dt.Rows[i]["prautstat"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prautstat"]) : 0;
                                    response.prautfsta = Convert.ToDateTime(dt.Rows[i]["prautfsta"]);
                                    response.prautmrcb = dt.Rows[i]["prautmrcb"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prautmrcb"]) : 0;

                                    response.prautfpro = Convert.ToDateTime(dt.Rows[i]["prautfpro"]);

                                    response.prautplaz = dt.Rows[i]["prautplaz"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prautplaz"]) : 0;
                                    response.prautagen = dt.Rows[i]["prautagen"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prautagen"]) : 0;
                                    response.prauttcta = dt.Rows[i]["prauttcta"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prauttcta"]) : 0;
                                    response.prautnmod = dt.Rows[i]["prautnmod"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prautnmod"]) : 0;

                                    response.prautglos = Convert.ToString(dt.Rows[i]["prautglos"]);        

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


        public List<PRCKC_RESPONSE> getPrckc()
        {
            var responseList = new List<PRCKC_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM prckc";
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
                                    var response = new PRCKC_RESPONSE();
                                    response.prckctcre = dt.Rows[i]["prckctcre"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prckctcre"]) : 0;
                                    response.prckccmon = dt.Rows[i]["prckccmon"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prckccmon"]) : 0;
                                    response.prckckcad = Convert.ToString(dt.Rows[i]["prckckcad"]);
                                    response.prckckcaa = Convert.ToString(dt.Rows[i]["prckckcaa"]);
                                   

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

        public List<PRCTA_RESPONSE> getPrcta()
        {
            var responseList = new List<PRCTA_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM praut";
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
                                    var response = new PRCTA_RESPONSE();
                                    response.prctacdki = Convert.ToString(dt.Rows[i]["prctacdki"]);
                                    response.prctaadki = dt.Rows[i]["prctaadki"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctaadki"]) : 0;
                                    response.prctacaki = Convert.ToString(dt.Rows[i]["prctacaki"]);
                                    response.prctaaaki = dt.Rows[i]["prctaaaki"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctaaaki"]) : 0;
                                    response.prctacdkp = Convert.ToString(dt.Rows[i]["prctacdkp"]);
                                    response.prctaadkp = dt.Rows[i]["prctaadkp"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctaadkp"]) : 0;
                                    response.prctacakp = Convert.ToString(dt.Rows[i]["prctacakp"]);
                                    response.prctaaakp = dt.Rows[i]["prctaaakp"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctaaakp"]) : 0;
                                    response.prctaccar = Convert.ToString(dt.Rows[i]["prctaccar"]);
                                   
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


        public List<PRCTL_RESPONSE> getPrctl()
        {
            var responseList = new List<PRCTL_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM prctl";
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
                                    var response = new PRCTL_RESPONSE();
                                    response.prctlndoc = dt.Rows[i]["prctlndoc"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlndoc"]) : 0;
                                    response.prctlgest = dt.Rows[i]["prctlgest"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlgest"]) : 0;
                                    response.prctlnser = dt.Rows[i]["prctlnser"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlnser"]) : 0;
                                    response.prctlprco = dt.Rows[i]["prctlprco"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlprco"]) : 0;

                          
                                    response.prctlcdpc = Convert.ToString(dt.Rows[i]["prctlcdpc"]);
                                    response.prctlcadc = Convert.ToString(dt.Rows[i]["prctlcadc"]);
                                    response.prctlcdfc = Convert.ToString(dt.Rows[i]["prctlcdfc"]);

                                    response.prctlfcie = Convert.ToDateTime(dt.Rows[i]["prctlfcie"]);
                                    response.prctlfcia = Convert.ToDateTime(dt.Rows[i]["prctlfcia"]);
                                    response.prctlfulb = Convert.ToDateTime(dt.Rows[i]["prctlfulb"]);
                                    response.prctlfalb = Convert.ToDateTime(dt.Rows[i]["prctlfalb"]);

                                    response.prctlcgmn = dt.Rows[i]["prctlcgmn"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlcgmn"]) : 0;
                                    response.prctlcgme = dt.Rows[i]["prctlcgme"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlcgme"]) : 0;
                                    response.prctlcgfv = dt.Rows[i]["prctlcgfv"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlcgfv"]) : 0;

                                    response.prctlfchv = Convert.ToString(dt.Rows[i]["prctlfchv"]);
                                    response.prctlrepr = Convert.ToString(dt.Rows[i]["prctlrepr"]);
                                    response.prctlcpen = Convert.ToString(dt.Rows[i]["prctlcpen"]);
                                    response.prctlfcor = Convert.ToDateTime(dt.Rows[i]["prctlfcor"]);

                                    response.prctldfdp = dt.Rows[i]["prctldfdp"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctldfdp"]) : 0;
                                    response.prctlfccg = Convert.ToDateTime(dt.Rows[i]["prctlfccg"]);
                                    response.prctlccvg = Convert.ToString(dt.Rows[i]["prctlccvg"]);
                                    response.prctlacvg = dt.Rows[i]["prctlacvg"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlacvg"]) : 0;
                                    response.prctlccvn = Convert.ToString(dt.Rows[i]["prctlccvn"]);
                                    response.prctlacvn = dt.Rows[i]["prctlacvn"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlacvn"]) : 0;
                                    response.prctlccej = Convert.ToString(dt.Rows[i]["prctlccej"]);
                                    response.prctlacej = dt.Rows[i]["prctlacej"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlacej"]) : 0;
                                    response.prctlcrvg = Convert.ToString(dt.Rows[i]["prctlcrvg"]);
                                    response.prctlarvg = dt.Rows[i]["prctlarvg"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlarvg"]) : 0;
                                    response.prctlcrvn = Convert.ToString(dt.Rows[i]["prctlcrvn"]);
                                    response.prctlarvn = dt.Rows[i]["prctlarvn"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlarvn"]) : 0;
                                    response.prctlcrej = Convert.ToString(dt.Rows[i]["prctlcrej"]);
                                    response.prctlarej = dt.Rows[i]["prctlarej"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlarej"]) : 0;
                                    response.prctldmor = dt.Rows[i]["prctldmor"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctldmor"]) : 0;
                                    response.prctlcmcr = dt.Rows[i]["prctlcmcr"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlcmcr"]) : 0;
                                    response.prctlpacr = dt.Rows[i]["prctlpacr"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["prctlpacr"]) : 0;
                                    response.prctldmmr = dt.Rows[i]["prctldmmr"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctldmmr"]) : 0;
                                    response.prctlnmxr = dt.Rows[i]["prctlnmxr"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prctlnmxr"]) : 0;

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

        public List<PRDEU_RESPONSE> getPrdeu()  //Hacer modelo prdeu
        {
            var responseList = new List<PRDEU_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM prdeu";
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
                                    var response = new PRDEU_RESPONSE();
                                    response.prdeunpre = dt.Rows[i]["prdeunpre"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prdeunpre"]) : 0;
                                    response.prdeucage = dt.Rows[i]["prdeucage"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prdeucage"]) : 0;
                                    response.prdeutres = dt.Rows[i]["prdeutres"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prdeutres"]) : 0;                           
                                    response.prdeuuser = Convert.ToString(dt.Rows[i]["prdeuuser"]);
                                    response.prdeuhora = Convert.ToString(dt.Rows[i]["prdeuhora"]);
                                    response.prdeufpro = Convert.ToDateTime(dt.Rows[i]["prdeufpro"]);
                                   
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




        public List<PRDIF_RESPONSE> getprdif()
        {
            var responseList = new List<PRDIF_RESPONSE>();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 20 * FROM prdif";
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
                                    var response = new PRDIF_RESPONSE();
                                    response.prdifnpre = dt.Rows[i]["prdifnpre"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prdifnpre"]) : 0;
                                    response.prdiffreg = Convert.ToString(dt.Rows[i]["prdiffreg"]);
                                    response.prdifcarg = dt.Rows[i]["prdifcarg"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prdifcarg"]) : 0;
                                    response.prdifmori = dt.Rows[i]["prdifmori"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["prdifmori"]) : 0;
                                    response.prdifmapr = dt.Rows[i]["prdifmapr"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["prdifmapr"]) : 0;
                                    response.prdifcuot = dt.Rows[i]["prdifcuot"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["prdifcuot"]) : 0;
                                    response.prdifsald = dt.Rows[i]["prdifsald"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["prdifsald"]) : 0;
                                    response.prdiffulp = Convert.ToString(dt.Rows[i]["prdiffulp"]);
                                    response.prdifglos = Convert.ToString(dt.Rows[i]["prdifglos"]);
                                    response.prdifreve = Convert.ToString(dt.Rows[i]["prdifreve"]);
                                    response.prdifmrcb = dt.Rows[i]["prdifmrcb"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prdifmrcb"]) : 0;
                                    response.prdiffmrc = Convert.ToString(dt.Rows[i]["prdiffmrc"]);
                                    response.prdifumrc = Convert.ToString(dt.Rows[i]["prdifumrc"]);
                                    response.prdifplaz = dt.Rows[i]["prdifplaz"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["prdifplaz"]) : 0;
                                    response.prdifagen = Convert.ToString(dt.Rows[i]["prdifagen"]);
                                    response.prdifuser = Convert.ToString(dt.Rows[i]["prdifuser"]);
                                    var aux = Convert.ToDateTime(dt.Rows[i]["prdifhora"]);
                                    response.prdifhora = aux.ToString("yyyy-MM-dd");
                                    response.prdiffpro = Convert.ToString(dt.Rows[i]["prdiffpro"]);
                                    response.prdiffapl = Convert.ToString(dt.Rows[i]["prdiffapl"]);
                                    response.prdifccap = dt.Rows[i]["prdifccap"] != System.DBNull.Value ? Convert.ToDecimal(dt.Rows[i]["prdifccap"]) : 0;

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






    }
}
