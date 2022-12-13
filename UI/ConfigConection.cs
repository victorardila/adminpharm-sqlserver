using System.Configuration;


namespace Presentacion
{
    public static class ConfigConnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        public static string ProviderName = ConfigurationManager.ConnectionStrings["conexion"].ProviderName;
    }
}
