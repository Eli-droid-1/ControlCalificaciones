using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private static string cadena =
            ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}