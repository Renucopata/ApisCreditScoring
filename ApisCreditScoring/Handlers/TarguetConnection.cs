namespace ApisCreditScoring.Handlers
{
    public class TarguetConnection
    {
        private String cadConexion = String.Empty;
        public TarguetConnection()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cadConexion = builder.GetSection("ConnectionStrings:ConexionTest1").Value;
        }
        public String get_cadConexion()
        {
            return cadConexion;
        }
    }
}
