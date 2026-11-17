using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ConexionBD
{
    internal class ConexionBD
    {

public class Conexion
    {
        public static string cadena =
            "server=localhost;database=Tienda;uid=root;pwd=Pas03xxx5672MYSQLdari03+;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadena);
        }
    }
}
}
