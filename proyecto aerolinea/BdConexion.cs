using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace proyecto_aerolinea
{
    class BdConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=aerolinea; Uid=root; pwd=root; SslMode=none; Port=3306;");
            conectar.Open();
            return conectar;
        }
    }
}
