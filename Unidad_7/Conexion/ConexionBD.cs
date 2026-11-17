using System;
using MySql.Data.MySqlClient;

namespace Unidad_7.Conexion
{
    public class ConexionBD
    {
        private static string cadenaConexion =
            "Server=localhost;Database=tienda;Uid=root;Pwd=a123456789;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}