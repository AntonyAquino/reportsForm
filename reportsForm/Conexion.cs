using MySql.Data.MySqlClient;
using System.Configuration;

public class Conexion
{
    private static string cadena = ConfigurationManager
        .ConnectionStrings["MiBaseDatos"].ConnectionString;

    public static MySqlConnection ObtenerConexion()
    {
        return new MySqlConnection(cadena);
    }
}