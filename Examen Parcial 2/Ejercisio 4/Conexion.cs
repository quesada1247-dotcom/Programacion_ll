using System;
using MySql.Data.MySqlClient;

namespace Examen_Parcial_2.Ejercicio_4
{
    public class Conexion
    {
        private static string cadenaConexion =
            "Server=localhost;" +
            "Port=3306;" +
            "Database=Tienda_Examen;" +
            "Uid=root;" +
            "Pwd=a123456789;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}