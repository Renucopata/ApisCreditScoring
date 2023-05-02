using ApisCreditScoring.Models;
using System.Data.SqlClient;
using System.Data;

namespace ApisCreditScoring.Handlers
{
    public class DataInsertor
    {

        public PROCEDURE_RESULT_RESPONSE insertGbaec(List<GBAEC_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBAEC_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBAEC", conexion);

                        cmd.Parameters.AddWithValue("gbaeccage", register.gbaeccage);
                        cmd.Parameters.AddWithValue("gbaeccaec", register.gbaeccaec);
                        cmd.Parameters.AddWithValue("gbaecfreg", register.gbaecfreg);
                        cmd.Parameters.AddWithValue("gbaecdesc", register.gbaecdesc);
                        cmd.Parameters.AddWithValue("gbaecisec", register.gbaecisec);
                        cmd.Parameters.AddWithValue("gbaecmrcb", register.gbaecmrcb);
                        cmd.Parameters.AddWithValue("gbaecmusr", register.gbaecmusr);
                        cmd.Parameters.AddWithValue("gbaecmhor", register.gbaecmhor);
                        cmd.Parameters.AddWithValue("gbaecmfec", register.gbaecmfec);
                        cmd.Parameters.AddWithValue("gbaecusrn", register.gbaecusrn);
                        cmd.Parameters.AddWithValue("gbaechora", register.gbaechora);
                        cmd.Parameters.AddWithValue("gbaecfpro", register.gbaecfpro);
                       
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }



        public PROCEDURE_RESULT_RESPONSE insertGbage(List<GBAGE_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();
          

            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach(GBAGE_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBAGE", conexion);

                        cmd.Parameters.AddWithValue("gbagecage", register.gbagecage);
                        cmd.Parameters.AddWithValue("gbagenomb", register.gbagenomb);
                        cmd.Parameters.AddWithValue("gbagetdid", register.gbagetdid);
                        cmd.Parameters.AddWithValue("gbagendid", register.gbagendid);
                        cmd.Parameters.AddWithValue("gbagenruc", register.gbagenruc);
                        cmd.Parameters.AddWithValue("gbagetper", register.gbagetper);
                        cmd.Parameters.AddWithValue("gbagefnac", register.gbagefnac);
                        cmd.Parameters.AddWithValue("gbagesexo", register.gbagesexo);
                        cmd.Parameters.AddWithValue("gbageeciv", register.gbageeciv);
                        cmd.Parameters.AddWithValue("gbagenaci", register.gbagenaci);
                        cmd.Parameters.AddWithValue("gbageprof", register.gbageprof);
                        cmd.Parameters.AddWithValue("gbagedir1", register.gbagedir1);
                        cmd.Parameters.AddWithValue("gbagedir2", register.gbagedir2);
                        cmd.Parameters.AddWithValue("gbageddo1", register.gbageddo1);
                        cmd.Parameters.AddWithValue("gbageddo2", register.gbageddo2);
                        cmd.Parameters.AddWithValue("gbagetlfd", register.gbagetlfd);
                        cmd.Parameters.AddWithValue("gbagetlfo", register.gbagetlfo);
                        cmd.Parameters.AddWithValue("gbagencas", register.gbagencas);
                        cmd.Parameters.AddWithValue("gbagenfax", register.gbagenfax);
                        cmd.Parameters.AddWithValue("gbagetlex", register.gbagetlex);
                        cmd.Parameters.AddWithValue("gbageciiu", register.gbageciiu);
                        cmd.Parameters.AddWithValue("gbageact1", register.gbageact1);
                        cmd.Parameters.AddWithValue("gbageact2", register.gbageact2);
                        cmd.Parameters.AddWithValue("gbagecalf", register.gbagecalf);
                        cmd.Parameters.AddWithValue("gbagefreg", register.gbagefreg);
                        cmd.Parameters.AddWithValue("gbageplaz", register.gbageplaz);
                        cmd.Parameters.AddWithValue("gbageagen", register.gbageagen);
                        cmd.Parameters.AddWithValue("gbageuser", register.gbageuser);
                        cmd.Parameters.AddWithValue("gbagehora", register.gbagehora);
                        cmd.Parameters.AddWithValue("gbagefpro", register.gbagefpro);
                        cmd.Parameters.AddWithValue("gbageclas", register.gbageclas);
                        cmd.Parameters.AddWithValue("gbagestat", register.gbagestat);
                        cmd.Parameters.AddWithValue("gbagefsta", register.gbagefsta);
                        cmd.Parameters.AddWithValue("gbagestaa", register.gbagestaa);
                        cmd.Parameters.AddWithValue("gbagefsaa", register.gbagefsaa);
                        cmd.Parameters.AddWithValue("gbageumrc", register.gbageumrc);
                        cmd.Parameters.AddWithValue("gbageumod", register.gbageumod);
                        cmd.Parameters.AddWithValue("gbagefmod", register.gbagefmod);
                        cmd.Parameters.AddWithValue("gbagefmrc", register.gbagefmrc);
                        cmd.Parameters.AddWithValue("gbagemrcb", register.gbagemrcb);
                        cmd.Parameters.AddWithValue("gbagecomp", register.gbagecomp);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }

                   
                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }
            
            return response;
        }


        public PROCEDURE_RESULT_RESPONSE insertGbben(List<GBBEN_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBBEN_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBBEN", conexion);

                        cmd.Parameters.AddWithValue("gbbencage", register.gbbencage);
                        cmd.Parameters.AddWithValue("gbbentseg", register.gbbentseg);
                        cmd.Parameters.AddWithValue("gbbenpate", register.gbbenpate);
                        cmd.Parameters.AddWithValue("gbbenmate", register.gbbenmate);
                        cmd.Parameters.AddWithValue("gbbennom1", register.gbbennom1);
                        cmd.Parameters.AddWithValue("gbbennom2", register.gbbennom2);
                        cmd.Parameters.AddWithValue("gbbenndid", register.gbbenndid);
                        cmd.Parameters.AddWithValue("gbbenpare", register.gbbenpare);
                        cmd.Parameters.AddWithValue("gbbenpart", register.gbbenpart);


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }


        public PROCEDURE_RESULT_RESPONSE insertGbcpo(List<GBCPO_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBCPO_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBCPO", conexion);

                        cmd.Parameters.AddWithValue("gbcpocage", register.gbcpocage);
                        cmd.Parameters.AddWithValue("gbcpofino", register.gbcpofino);
                        cmd.Parameters.AddWithValue("gbcponmod", register.gbcponmod);
                        cmd.Parameters.AddWithValue("gbcpooper", register.gbcpooper);
                        cmd.Parameters.AddWithValue("gbcpocodb", register.gbcpocodb);
                        cmd.Parameters.AddWithValue("gbcpootro", register.gbcpootro);
                        cmd.Parameters.AddWithValue("gbcpobeni", register.gbcpobeni);
                        cmd.Parameters.AddWithValue("gbcpofini", register.gbcpofini);
                        cmd.Parameters.AddWithValue("gbcpouser", register.gbcpouser);
                        cmd.Parameters.AddWithValue("gbcpohora", register.gbcpohora);
                        cmd.Parameters.AddWithValue("gbcpofpro", register.gbcpofpro);


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }

        public PROCEDURE_RESULT_RESPONSE insertGbcsf(List<GBCSF_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBCSF_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBCSF", conexion);

                        cmd.Parameters.AddWithValue("gbcsfdpto", register.gbcsfdpto);
                        cmd.Parameters.AddWithValue("gbcsfciud", register.gbcsfciud);
                        cmd.Parameters.AddWithValue("gbcsfdpt1", register.gbcsfdpt1);
                        cmd.Parameters.AddWithValue("gbcsfdesc", register.gbcsfdesc);
                        cmd.Parameters.AddWithValue("gbcsfprov", register.gbcsfprov);
                        cmd.Parameters.AddWithValue("gbcsfsecc", register.gbcsfsecc);
                        cmd.Parameters.AddWithValue("gbcsfcant", register.gbcsfcant);
        
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }


        public PROCEDURE_RESULT_RESPONSE insertGbdac(List<GBDAC_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBDAC_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBDAC", conexion);

                        cmd.Parameters.AddWithValue("gbdaccage", register.gbdaccage);
                        cmd.Parameters.AddWithValue("gbdacnomb", register.gbdacnomb);
                        cmd.Parameters.AddWithValue("gbdacape1", register.gbdacape1);
                        cmd.Parameters.AddWithValue("gbdacape2", register.gbdacape2);
                        cmd.Parameters.AddWithValue("gbdacnoco", register.gbdacnoco);
                        cmd.Parameters.AddWithValue("gbdaccocl", register.gbdaccocl);
                        cmd.Parameters.AddWithValue("gbdacrefp", register.gbdacrefp);
                        cmd.Parameters.AddWithValue("gbdacmail", register.gbdacmail);
                        cmd.Parameters.AddWithValue("gbdacciud", register.gbdacciud);
                        cmd.Parameters.AddWithValue("gbdacubid", register.gbdacubid);
                        cmd.Parameters.AddWithValue("gbdacrefd", register.gbdacrefd);
                        cmd.Parameters.AddWithValue("gbdacnemp", register.gbdacnemp);
                        cmd.Parameters.AddWithValue("gbdacccar", register.gbdacccar);
                        cmd.Parameters.AddWithValue("gbdacnint", register.gbdacnint);
                        cmd.Parameters.AddWithValue("gbdacciuo", register.gbdacciuo);
                        cmd.Parameters.AddWithValue("gbdacubio", register.gbdacubio);
                        cmd.Parameters.AddWithValue("gbdacrefo", register.gbdacrefo);
                        cmd.Parameters.AddWithValue("gbdacfing", register.gbdacfing);
                        cmd.Parameters.AddWithValue("gbdacrseg", register.gbdacrseg);
                        cmd.Parameters.AddWithValue("gbdactres", register.gbdactres);
                        cmd.Parameters.AddWithValue("gbdacnori", register.gbdacnori);
                        cmd.Parameters.AddWithValue("gbdacfcna", register.gbdacfcna);
                        cmd.Parameters.AddWithValue("gbdacflle", register.gbdacflle);
                        cmd.Parameters.AddWithValue("gbdacstat", register.gbdacstat);
                        cmd.Parameters.AddWithValue("gbdacfsta", register.gbdacfsta);
                        cmd.Parameters.AddWithValue("gbdacsant", register.gbdacsant);
                        cmd.Parameters.AddWithValue("gbdacfant", register.gbdacfant);
                        cmd.Parameters.AddWithValue("gbdaccnac", register.gbdaccnac);
                        cmd.Parameters.AddWithValue("gbdacmens", register.gbdacmens);
                        cmd.Parameters.AddWithValue("gbdactmen", register.gbdactmen);
                        cmd.Parameters.AddWithValue("gbdacneva", register.gbdacneva);
                        cmd.Parameters.AddWithValue("gbdacfeva", register.gbdacfeva);
                        cmd.Parameters.AddWithValue("gbdaccony", register.gbdaccony);
                        cmd.Parameters.AddWithValue("gbdacnive", register.gbdacnive);
                        cmd.Parameters.AddWithValue("gbdaccand", register.gbdaccand);
                        cmd.Parameters.AddWithValue("gbdacclfa", register.gbdacclfa);
                        cmd.Parameters.AddWithValue("gbdacfcaa", register.gbdacfcaa);
                        cmd.Parameters.AddWithValue("gbdacfcal", register.gbdacfcal);
                        cmd.Parameters.AddWithValue("gbdacfuad", register.gbdacfuad);
                        cmd.Parameters.AddWithValue("gbdaccelu", register.gbdaccelu);
                        cmd.Parameters.AddWithValue("gbdacclas", register.gbdacclas);
                        cmd.Parameters.AddWithValue("gbdacnom1", register.gbdacnom1);
                        cmd.Parameters.AddWithValue("gbdacnom2", register.gbdacnom2);
                        cmd.Parameters.AddWithValue("gbdacape3", register.gbdacape3);
                        cmd.Parameters.AddWithValue("gbdactmto", register.gbdactmto);
                        cmd.Parameters.AddWithValue("gbdaccncn", register.gbdaccncn);
                        cmd.Parameters.AddWithValue("gbdaccnco", register.gbdaccnco);
                        cmd.Parameters.AddWithValue("gbdacpaip", register.gbdacpaip);
                        cmd.Parameters.AddWithValue("gbdacrubr", register.gbdacrubr);
                        cmd.Parameters.AddWithValue("gbdacsect", register.gbdacsect);
                        cmd.Parameters.AddWithValue("gbdacactv", register.gbdacactv);
                        cmd.Parameters.AddWithValue("gbdacclsc", register.gbdacclsc);
                        cmd.Parameters.AddWithValue("gbdactipo", register.gbdactipo);
                        cmd.Parameters.AddWithValue("gbdacpweb", register.gbdacpweb);
                        cmd.Parameters.AddWithValue("gbdacobsv", register.gbdacobsv);
                        cmd.Parameters.AddWithValue("gbdacrepr", register.gbdacrepr);
                        cmd.Parameters.AddWithValue("gbdaccicl", register.gbdaccicl);
                        cmd.Parameters.AddWithValue("gbdacambg", register.gbdacambg);
                        cmd.Parameters.AddWithValue("gbdacidip", register.gbdacidip);
                        cmd.Parameters.AddWithValue("gbdacidis", register.gbdacidis);
                        cmd.Parameters.AddWithValue("gbdacciun", register.gbdacciun);
                        cmd.Parameters.AddWithValue("gbdacpeso", register.gbdacpeso);
                        cmd.Parameters.AddWithValue("gbdacestt", register.gbdacestt);
                        cmd.Parameters.AddWithValue("gbdacfmat", register.gbdacfmat);
                        cmd.Parameters.AddWithValue("gbdacnfam", register.gbdacnfam);
                        cmd.Parameters.AddWithValue("gbdaccalp", register.gbdaccalp);
                        cmd.Parameters.AddWithValue("gbdaclact", register.gbdaclact);
                        cmd.Parameters.AddWithValue("gbdacfiac", register.gbdacfiac);
                        cmd.Parameters.AddWithValue("gbdactaac", register.gbdactaac);
                        cmd.Parameters.AddWithValue("gbdactmac", register.gbdactmac);
                        cmd.Parameters.AddWithValue("gbdactdac", register.gbdactdac);
                        cmd.Parameters.AddWithValue("gbdacidac", register.gbdacidac);
                        cmd.Parameters.AddWithValue("gbdacdisc", register.gbdacdisc);
                        cmd.Parameters.AddWithValue("gbdactdis", register.gbdactdis);



                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }

        public PROCEDURE_RESULT_RESPONSE insertGbdac_h(List<GBDAC_H_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBDAC_H_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBDAC_H", conexion);

                        cmd.Parameters.AddWithValue("gbdaccage", register.gbdaccage);
                        cmd.Parameters.AddWithValue("gbdacnomb", register.gbdacnomb);
                        cmd.Parameters.AddWithValue("gbdacape1", register.gbdacape1);
                        cmd.Parameters.AddWithValue("gbdacape2", register.gbdacape2);
                        cmd.Parameters.AddWithValue("gbdacnoco", register.gbdacnoco);
                        cmd.Parameters.AddWithValue("gbdaccocl", register.gbdaccocl);
                        cmd.Parameters.AddWithValue("gbdacrefp", register.gbdacrefp);
                        cmd.Parameters.AddWithValue("gbdacmail", register.gbdacmail);
                        cmd.Parameters.AddWithValue("gbdacciud", register.gbdacciud);
                        cmd.Parameters.AddWithValue("gbdacubid", register.gbdacubid);
                        cmd.Parameters.AddWithValue("gbdacrefd", register.gbdacrefd);
                        cmd.Parameters.AddWithValue("gbdacnemp", register.gbdacnemp);
                        cmd.Parameters.AddWithValue("gbdacccar", register.gbdacccar);
                        cmd.Parameters.AddWithValue("gbdacnint", register.gbdacnint);
                        cmd.Parameters.AddWithValue("gbdacciuo", register.gbdacciuo);
                        cmd.Parameters.AddWithValue("gbdacubio", register.gbdacubio);
                        cmd.Parameters.AddWithValue("gbdacrefo", register.gbdacrefo);
                        cmd.Parameters.AddWithValue("gbdacfing", register.gbdacfing);
                        cmd.Parameters.AddWithValue("gbdacrseg", register.gbdacrseg);
                        cmd.Parameters.AddWithValue("gbdactres", register.gbdactres);
                        cmd.Parameters.AddWithValue("gbdacnori", register.gbdacnori);
                        cmd.Parameters.AddWithValue("gbdacfcna", register.gbdacfcna);
                        cmd.Parameters.AddWithValue("gbdacflle", register.gbdacflle);
                        cmd.Parameters.AddWithValue("gbdacstat", register.gbdacstat);
                        cmd.Parameters.AddWithValue("gbdacfsta", register.gbdacfsta);
                        cmd.Parameters.AddWithValue("gbdacsant", register.gbdacsant);
                        cmd.Parameters.AddWithValue("gbdacfant", register.gbdacfant);
                        cmd.Parameters.AddWithValue("gbdaccnac", register.gbdaccnac);
                        cmd.Parameters.AddWithValue("gbdacmens", register.gbdacmens);
                        cmd.Parameters.AddWithValue("gbdactmen", register.gbdactmen);
                        cmd.Parameters.AddWithValue("gbdacneva", register.gbdacneva);
                        cmd.Parameters.AddWithValue("gbdacfeva", register.gbdacfeva);
                        cmd.Parameters.AddWithValue("gbdaccony", register.gbdaccony);
                        cmd.Parameters.AddWithValue("gbdacnive", register.gbdacnive);
                        cmd.Parameters.AddWithValue("gbdaccand", register.gbdaccand);
                        cmd.Parameters.AddWithValue("gbdacclfa", register.gbdacclfa);
                        cmd.Parameters.AddWithValue("gbdacfcaa", register.gbdacfcaa);
                        cmd.Parameters.AddWithValue("gbdacfcal", register.gbdacfcal);
                        cmd.Parameters.AddWithValue("gbdacfuad", register.gbdacfuad);
                        cmd.Parameters.AddWithValue("gbdaccelu", register.gbdaccelu);
                        cmd.Parameters.AddWithValue("gbdacclas", register.gbdacclas);
                        cmd.Parameters.AddWithValue("gbdacnom1", register.gbdacnom1);
                        cmd.Parameters.AddWithValue("gbdacnom2", register.gbdacnom2);
                        cmd.Parameters.AddWithValue("gbdacape3", register.gbdacape3);
                        cmd.Parameters.AddWithValue("gbdactmto", register.gbdactmto);
                        cmd.Parameters.AddWithValue("gbdaccncn", register.gbdaccncn);
                        cmd.Parameters.AddWithValue("gbdaccnco", register.gbdaccnco);
                        cmd.Parameters.AddWithValue("gbdacpaip", register.gbdacpaip);
                        cmd.Parameters.AddWithValue("gbdacrubr", register.gbdacrubr);
                        cmd.Parameters.AddWithValue("gbdacsect", register.gbdacsect);
                        cmd.Parameters.AddWithValue("gbdacactv", register.gbdacactv);
                        cmd.Parameters.AddWithValue("gbdacclsc", register.gbdacclsc);
                        cmd.Parameters.AddWithValue("gbdactipo", register.gbdactipo);
                        cmd.Parameters.AddWithValue("gbdacpweb", register.gbdacpweb);
                        cmd.Parameters.AddWithValue("gbdacobsv", register.gbdacobsv);
                        cmd.Parameters.AddWithValue("gbdacrepr", register.gbdacrepr);
                        cmd.Parameters.AddWithValue("gbdaccicl", register.gbdaccicl);
                        cmd.Parameters.AddWithValue("gbdacambg", register.gbdacambg);
                        cmd.Parameters.AddWithValue("gbdacidip", register.gbdacidip);
                        cmd.Parameters.AddWithValue("gbdacidis", register.gbdacidis);
                        cmd.Parameters.AddWithValue("gbdacciun", register.gbdacciun);
                        cmd.Parameters.AddWithValue("gbdacpeso", register.gbdacpeso);
                        cmd.Parameters.AddWithValue("gbdacestt", register.gbdacestt);
                        cmd.Parameters.AddWithValue("gbdacfmat", register.gbdacfmat);
                        cmd.Parameters.AddWithValue("gbdacnfam", register.gbdacnfam);
                        cmd.Parameters.AddWithValue("gbdaccalp", register.gbdaccalp);
                        cmd.Parameters.AddWithValue("gbdaclact", register.gbdaclact);
                        cmd.Parameters.AddWithValue("gbdacfiac", register.gbdacfiac);
                        cmd.Parameters.AddWithValue("gbdactaac", register.gbdactaac);
                        cmd.Parameters.AddWithValue("gbdactmac", register.gbdactmac);
                        cmd.Parameters.AddWithValue("gbdactdac", register.gbdactdac);
                        cmd.Parameters.AddWithValue("gbdacidac", register.gbdacidac);
                        cmd.Parameters.AddWithValue("gbdacusrl", register.gbdacusrl);
                        cmd.Parameters.AddWithValue("gbdacdate", register.gbdacdate);
                        cmd.Parameters.AddWithValue("gbdacevto", register.gbdacevto);



                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }


        public PROCEDURE_RESULT_RESPONSE insertGbdbi(List<GBDBI_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBDBI_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBDBI", conexion);

                        cmd.Parameters.AddWithValue("gbdbicage", register.gbdbicage);
                        cmd.Parameters.AddWithValue("gbdbifech", register.gbdbifech);
                        cmd.Parameters.AddWithValue("gbdbicmon", register.gbdbicmon);
                        cmd.Parameters.AddWithValue("gbdbitviv", register.gbdbitviv);
                        cmd.Parameters.AddWithValue("gbdbiaemp", register.gbdbiaemp);
                        cmd.Parameters.AddWithValue("gbdbiifij", register.gbdbiifij);
                        cmd.Parameters.AddWithValue("gbdbiivar", register.gbdbiivar);
                        cmd.Parameters.AddWithValue("gbdbigfij", register.gbdbigfij);
                        cmd.Parameters.AddWithValue("gbdbigvar", register.gbdbigvar);
                        cmd.Parameters.AddWithValue("gbdbitact", register.gbdbitact);
                        cmd.Parameters.AddWithValue("gbdbitpas", register.gbdbitpas);
                        cmd.Parameters.AddWithValue("gbdbipatr", register.gbdbipatr);
                        cmd.Parameters.AddWithValue("gbdbiisal", register.gbdbiisal);
                        cmd.Parameters.AddWithValue("gbdbiporc", register.gbdbiporc);
                        cmd.Parameters.AddWithValue("gbdbitotv", register.gbdbitotv);
                        cmd.Parameters.AddWithValue("gbdbicper", register.gbdbicper);
                        cmd.Parameters.AddWithValue("gbdbiinde", register.gbdbiinde);
                        cmd.Parameters.AddWithValue("gbdbitpre", register.gbdbitpre);
                        cmd.Parameters.AddWithValue("gbdbiciiu", register.gbdbiciiu);
                        cmd.Parameters.AddWithValue("gbdbicate", register.gbdbicate);
                        cmd.Parameters.AddWithValue("gbdbiscii", register.gbdbiscii);
                        cmd.Parameters.AddWithValue("gbdbitcof", register.gbdbitcof);
                        cmd.Parameters.AddWithValue("gbdbicapa", register.gbdbicapa);
                        cmd.Parameters.AddWithValue("gbdbiuser", register.gbdbiuser);
                        cmd.Parameters.AddWithValue("gbdbihora", register.gbdbihora);
                        cmd.Parameters.AddWithValue("gbdbifpro", register.gbdbifpro);




                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }


        public PROCEDURE_RESULT_RESPONSE insertGbdeu(List<GBDEU_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBDEU_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBDEU", conexion);

                        cmd.Parameters.AddWithValue("gbdeucage", register.gbdeucage);
                        cmd.Parameters.AddWithValue("gbdeuimpt", register.gbdeuimpt);
                        cmd.Parameters.AddWithValue("gbdeucmon", register.gbdeucmon);
                        cmd.Parameters.AddWithValue("gbdeutdeu", register.gbdeutdeu);
                        cmd.Parameters.AddWithValue("gbdeutotd", register.gbdeutotd);
                        cmd.Parameters.AddWithValue("gbdeufech", register.gbdeufech);
                        cmd.Parameters.AddWithValue("gbdeugara", register.gbdeugara);
                        cmd.Parameters.AddWithValue("gbdeugarl", register.gbdeugarl);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }


        public PROCEDURE_RESULT_RESPONSE insertGbdgo(List<GBDGO_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBDGO_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBDGO", conexion);

                        cmd.Parameters.AddWithValue("gbdgonsol", register.gbdgonsol);
                        cmd.Parameters.AddWithValue("gbdgocage", register.gbdgocage);
                        cmd.Parameters.AddWithValue("gbdgofreg", register.gbdgofreg);
                        cmd.Parameters.AddWithValue("gbdgocins", register.gbdgocins);
                        cmd.Parameters.AddWithValue("gbdgonopr", register.gbdgonopr);
                        cmd.Parameters.AddWithValue("gbdgocalf", register.gbdgocalf);
                        cmd.Parameters.AddWithValue("gbdgodest", register.gbdgodest);
                        cmd.Parameters.AddWithValue("gbdgostat", register.gbdgostat);
                        cmd.Parameters.AddWithValue("gbdgocmon", register.gbdgocmon);
                        cmd.Parameters.AddWithValue("gbdgocuom", register.gbdgocuom);
                        cmd.Parameters.AddWithValue("gbdgoncuo", register.gbdgoncuo);
                        cmd.Parameters.AddWithValue("gbdgoncup", register.gbdgoncup);
                        cmd.Parameters.AddWithValue("gbdgoplzo", register.gbdgoplzo);
                        cmd.Parameters.AddWithValue("gbdgomont", register.gbdgomont);
                        cmd.Parameters.AddWithValue("gbdgomdes", register.gbdgomdes);
                        cmd.Parameters.AddWithValue("gbdgotdeu", register.gbdgotdeu);
                        cmd.Parameters.AddWithValue("gbdgofech", register.gbdgofech);
                        cmd.Parameters.AddWithValue("gbdgottas", register.gbdgottas);
                        cmd.Parameters.AddWithValue("gbdgotasa", register.gbdgotasa);
                        cmd.Parameters.AddWithValue("gbdgotdei", register.gbdgotdei);
                        cmd.Parameters.AddWithValue("gbdgotres", register.gbdgotres);
                        cmd.Parameters.AddWithValue("gbdgousrn", register.gbdgousrn);
                        cmd.Parameters.AddWithValue("gbdgohora", register.gbdgohora);
                        cmd.Parameters.AddWithValue("gbdgofpro", register.gbdgofpro);




                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }


        public PROCEDURE_RESULT_RESPONSE insertGbdic(List<GBDIC_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBDIC_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBDIC", conexion);

                        cmd.Parameters.AddWithValue("gbdiccage", register.gbdiccage);
                        cmd.Parameters.AddWithValue("gbdicfreg", register.gbdicfreg);
                        cmd.Parameters.AddWithValue("gbdicidir", register.gbdicidir);
                        cmd.Parameters.AddWithValue("gbdiccdep", register.gbdiccdep);
                        cmd.Parameters.AddWithValue("gbdiccobr", register.gbdiccobr);
                        cmd.Parameters.AddWithValue("gbdiccpro", register.gbdiccpro);
                        cmd.Parameters.AddWithValue("gbdicheda", register.gbdicheda);
                        cmd.Parameters.AddWithValue("gbdichned", register.gbdichned);
                        cmd.Parameters.AddWithValue("gbdichced", register.gbdichced);
                        cmd.Parameters.AddWithValue("gbdictres", register.gbdictres);
                        cmd.Parameters.AddWithValue("gbdictten", register.gbdictten);
                        cmd.Parameters.AddWithValue("gbdictviv", register.gbdictviv);
                        cmd.Parameters.AddWithValue("gbdicdviv", register.gbdicdviv);
                        cmd.Parameters.AddWithValue("gbdictpar", register.gbdictpar);
                        cmd.Parameters.AddWithValue("gbdictpis", register.gbdictpis);
                        cmd.Parameters.AddWithValue("gbdicttec", register.gbdicttec);
                        cmd.Parameters.AddWithValue("gbdicsagu", register.gbdicsagu);
                        cmd.Parameters.AddWithValue("gbdicsluz", register.gbdicsluz);
                        cmd.Parameters.AddWithValue("gbdicsalc", register.gbdicsalc);
                        cmd.Parameters.AddWithValue("gbdicstlf", register.gbdicstlf);
                        cmd.Parameters.AddWithValue("gbdicstce", register.gbdicstce);
                        cmd.Parameters.AddWithValue("gbdicpavi", register.gbdicpavi);
                        cmd.Parameters.AddWithValue("gbdiccocu", register.gbdiccocu);
                        cmd.Parameters.AddWithValue("gbdicccto", register.gbdicccto);
                        cmd.Parameters.AddWithValue("gbdiccbno", register.gbdiccbno);
                        cmd.Parameters.AddWithValue("gbdiccduc", register.gbdiccduc);
                        cmd.Parameters.AddWithValue("gbdiccref", register.gbdiccref);
                        cmd.Parameters.AddWithValue("gbdicctel", register.gbdicctel);
                        cmd.Parameters.AddWithValue("gbdiccdvd", register.gbdiccdvd);
                        cmd.Parameters.AddWithValue("gbdiccmes", register.gbdiccmes);
                        cmd.Parameters.AddWithValue("gbdiccveh", register.gbdiccveh);
                        cmd.Parameters.AddWithValue("gbdiccoce", register.gbdiccoce);
                        cmd.Parameters.AddWithValue("gbdiccmbc", register.gbdiccmbc);
                        cmd.Parameters.AddWithValue("gbdicrdrr", register.gbdicrdrr);
                        cmd.Parameters.AddWithValue("gbdicmtrf", register.gbdicmtrf);
                        cmd.Parameters.AddWithValue("gbdicodoc", register.gbdicodoc);
                        cmd.Parameters.AddWithValue("gbdicddoc", register.gbdicddoc);
                        cmd.Parameters.AddWithValue("gbdicario", register.gbdicario);
                        cmd.Parameters.AddWithValue("gbdicamnt", register.gbdicamnt);
                        cmd.Parameters.AddWithValue("gbdicabot", register.gbdicabot);
                        cmd.Parameters.AddWithValue("gbdicafab", register.gbdicafab);
                        cmd.Parameters.AddWithValue("gbdicaotr", register.gbdicaotr);
                        cmd.Parameters.AddWithValue("gbdicscul", register.gbdicscul);
                        cmd.Parameters.AddWithValue("gbdicuser", register.gbdicuser);
                        cmd.Parameters.AddWithValue("gbdichora", register.gbdichora);
                        cmd.Parameters.AddWithValue("gbdicfpro", register.gbdicfpro);
                        cmd.Parameters.AddWithValue("gbdicnhij", register.gbdicnhij);
                        cmd.Parameters.AddWithValue("gbdicsgdo", register.gbdicsgdo);
                        cmd.Parameters.AddWithValue("gbdicceso", register.gbdicceso);
                        cmd.Parameters.AddWithValue("gbdicglos", register.gbdicglos);
                        cmd.Parameters.AddWithValue("gbdicnmat", register.gbdicnmat);
                        cmd.Parameters.AddWithValue("gbdicspro", register.gbdicspro);
                        cmd.Parameters.AddWithValue("gbdicunid", register.gbdicunid);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }


        public PROCEDURE_RESULT_RESPONSE insertGbdoc_h(List<GBDOC_H_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBDOC_H_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBDOC_H", conexion);

                        cmd.Parameters.AddWithValue("gbdoccage", register.gbdoccage);
                        cmd.Parameters.AddWithValue("gbdocndid", register.gbdocndid);
                        cmd.Parameters.AddWithValue("gbdocfvid", register.gbdocfvid);
                        cmd.Parameters.AddWithValue("gbdocnruc", register.gbdocnruc);
                        cmd.Parameters.AddWithValue("gbdocfvru", register.gbdocfvru);
                        cmd.Parameters.AddWithValue("gbdocfreg", register.gbdocfreg);
                        cmd.Parameters.AddWithValue("gbdocplaz", register.gbdocplaz);
                        cmd.Parameters.AddWithValue("gbdocagen", register.gbdocagen);
                        cmd.Parameters.AddWithValue("gbdocuser", register.gbdocuser);
                        cmd.Parameters.AddWithValue("gbdochora", register.gbdochora);
                        cmd.Parameters.AddWithValue("gbdocfpro", register.gbdocfpro);
                        cmd.Parameters.AddWithValue("gbdocusrl", register.gbdocusrl);
                        cmd.Parameters.AddWithValue("gbdocdate", register.gbdocdate);
                        cmd.Parameters.AddWithValue("gbdocevto", register.gbdocevto);
                        

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }

        public PROCEDURE_RESULT_RESPONSE insertGbema(List<GBEMA_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBEMA_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBEMA", conexion);

                        cmd.Parameters.AddWithValue("gbemacage", register.gbemacage);
                        cmd.Parameters.AddWithValue("gbemaitem", register.gbemaitem);
                        cmd.Parameters.AddWithValue("gbemamail", register.gbemamail);
                        cmd.Parameters.AddWithValue("gbemamrpi", register.gbemamrpi);
                        cmd.Parameters.AddWithValue("gbemamrcb", register.gbemamrcb);
                        cmd.Parameters.AddWithValue("gbemafmrc", register.gbemafmrc);
                        cmd.Parameters.AddWithValue("gbemauser", register.gbemauser);
                        cmd.Parameters.AddWithValue("gbemahora", register.gbemahora);
                        cmd.Parameters.AddWithValue("gbemafpro", register.gbemafpro);
                        


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }


        public PROCEDURE_RESULT_RESPONSE insertGbhca(List<GBHCA_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (GBHCA_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_GBHCA", conexion);

                        cmd.Parameters.AddWithValue("gbhcafreg", register.gbhcafreg);
                        cmd.Parameters.AddWithValue("gbhcatcal", register.gbhcatcal);
                        cmd.Parameters.AddWithValue("gbhcamodn", register.gbhcamodn);
                        cmd.Parameters.AddWithValue("gbhcanopr", register.gbhcanopr);
                        cmd.Parameters.AddWithValue("gbhcacage", register.gbhcacage);
                        cmd.Parameters.AddWithValue("gbhcacalf", register.gbhcacalf);
                        cmd.Parameters.AddWithValue("gbhcaclfa", register.gbhcaclfa);
                        cmd.Parameters.AddWithValue("gbhcappgk", register.gbhcappgk);
                        cmd.Parameters.AddWithValue("gbhcacmon", register.gbhcacmon);
                        cmd.Parameters.AddWithValue("gbhcasald", register.gbhcasald);
                        cmd.Parameters.AddWithValue("gbhcaendt", register.gbhcaendt);
                        cmd.Parameters.AddWithValue("gbhcastat", register.gbhcastat);
                        cmd.Parameters.AddWithValue("gbhcafpvc", register.gbhcafpvc);
                        cmd.Parameters.AddWithValue("gbhcadias", register.gbhcadias);
                        cmd.Parameters.AddWithValue("gbhcabipn", register.gbhcabipn);
                        cmd.Parameters.AddWithValue("gbhcaglos", register.gbhcaglos);
                        cmd.Parameters.AddWithValue("gbhcauser", register.gbhcauser);
                        cmd.Parameters.AddWithValue("gbhcahora", register.gbhcahora);
                        cmd.Parameters.AddWithValue("gbhcafpro", register.gbhcafpro);
                        cmd.Parameters.AddWithValue("gbhcacclf", register.gbhcacclf);
                        cmd.Parameters.AddWithValue("gbhcacpac", register.gbhcacpac);


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }



        //pRESTAMOS COMERCIALES INSERTORS

        public PROCEDURE_RESULT_RESPONSE insertPrdeu(List<PRDEU_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (PRDEU_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_PRDEU", conexion);

                        cmd.Parameters.AddWithValue("prdeunpre", register.prdeunpre);
                        cmd.Parameters.AddWithValue("prdeucage", register.prdeucage);
                        cmd.Parameters.AddWithValue("prdeutres", register.prdeutres);
                        cmd.Parameters.AddWithValue("prdeuuser", register.prdeuuser);
                        cmd.Parameters.AddWithValue("prdeuhora", register.prdeuhora);
                        cmd.Parameters.AddWithValue("prdeufpro", register.prdeufpro);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }





        public PROCEDURE_RESULT_RESPONSE insertPrdif(List<PRDIF_RESPONSE> rows)
        {
            var response = new PROCEDURE_RESULT_RESPONSE();


            try
            {
                var cn = new TarguetConnection();
                using (var conexion = new SqlConnection(cn.get_cadConexion()))
                {
                    conexion.Open();
                    foreach (PRDIF_RESPONSE register in rows)
                    {
                        SqlCommand cmd = new SqlCommand("SP_INSERT_PRDIF", conexion);

                        cmd.Parameters.AddWithValue("prdifnpre", register.prdifnpre);
                        cmd.Parameters.AddWithValue("prdiffreg", register.prdiffreg);
                        cmd.Parameters.AddWithValue("prdifcarg", register.prdifcarg);
                        cmd.Parameters.AddWithValue("prdifmori", register.prdifmori);
                        cmd.Parameters.AddWithValue("prdifmapr", register.prdifmapr);
                        cmd.Parameters.AddWithValue("prdifcuot", register.prdifcuot);
                        cmd.Parameters.AddWithValue("prdifsald", register.prdifsald);
                        cmd.Parameters.AddWithValue("prdiffulp", register.prdiffulp);
                        cmd.Parameters.AddWithValue("prdifglos", register.prdifglos);
                        cmd.Parameters.AddWithValue("prdifreve", register.prdifreve);
                        cmd.Parameters.AddWithValue("prdifmrcb", register.prdifmrcb);
                        cmd.Parameters.AddWithValue("prdiffmrc", register.prdiffmrc);
                        cmd.Parameters.AddWithValue("prdifumrc", register.prdifumrc);
                        cmd.Parameters.AddWithValue("prdifplaz", register.prdifplaz);
                        cmd.Parameters.AddWithValue("prdifagen", register.prdifagen);
                        cmd.Parameters.AddWithValue("prdifuser", register.prdifuser);
                        cmd.Parameters.AddWithValue("prdifhora", register.prdifhora);
                        cmd.Parameters.AddWithValue("prdiffpro", register.prdiffpro);
                        cmd.Parameters.AddWithValue("prdiffapl", register.prdiffapl);
                        cmd.Parameters.AddWithValue("prdifccap", register.prdifccap);




                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }


                }
                response.procedureComplete = true;
                response.message = "Procedure successfully completed";
            }
            catch (Exception e)
            {
                string error = e.Message;
                response.procedureComplete = false;
                response.message = error;
            }

            return response;
        }
    }
}
