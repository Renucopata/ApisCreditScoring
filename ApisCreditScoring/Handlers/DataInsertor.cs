using ApisCreditScoring.Models;
using System.Data.SqlClient;
using System.Data;

namespace ApisCreditScoring.Handlers
{
    public class DataInsertor
    {

        public bool insertGbage(List<GBAGE_RESPONSE> rows)
        {
            bool response;
          

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
                response = true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                response = false;
            }
            
            return response;
        }
    }
}
