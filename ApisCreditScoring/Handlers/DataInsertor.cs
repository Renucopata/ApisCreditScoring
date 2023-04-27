using ApisCreditScoring.Models;
using System.Data.SqlClient;
using System.Data;

namespace ApisCreditScoring.Handlers
{
    public class DataInsertor
    {

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
