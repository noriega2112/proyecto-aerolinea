using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace proyecto_aerolinea
{
    class aviBD
    {
        public static int Agregar(_avion pAvion)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("Insert into avion(avi_tipo, pil_id) values('{0}', '{1}')", pAvion.avi_tipo, pAvion.pil_id), BdConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static _avion obtenerAvion(int avi_id)
        {
            _avion pAvion = new _avion();
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select * from avion where avi_id ='{0}'", avi_id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pAvion.avi_id = _reader.GetInt16(0);
                pAvion.avi_tipo = _reader.GetString(1);
                pAvion.pil_id = _reader.GetInt16(2);
            }
            conexion.Close();
            return pAvion;
        }

        public static int totalPilotos()
        {
            int total = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select count(*) from piloto;"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                total = _reader.GetInt16(0);
            }
            conexion.Close();
            return total;
        }

        public static List<_avion> BuscarT()
        {

            List<_avion> _lista = new List<_avion>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select avi_id as 'ID', avi_tipo as 'Tipo de Avión', pil_id as 'Id del piloto' from avion;"), BdConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                _avion pAvion = new _avion();
                pAvion.avi_id = _reader.GetInt16(0);
                pAvion.avi_tipo = _reader.GetString(1);
                pAvion.pil_id = _reader.GetInt16(2);
                _lista.Add(pAvion);
            }
            return _lista;
        }

        public static string Buscar(int id)
        {
            string nombrePiloto = " ";
            List<_boleto> _lista = new List<_boleto>();
            MySqlCommand _comando = new MySqlCommand(String.Format("select concat(emp_nom , ' ', emp_ape) from piloto, avion, empleado where piloto.pil_id = avion.pil_id and piloto.emp_id = empleado.emp_id and avi_id = '{0}';", id), BdConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                nombrePiloto = _reader.GetString(0);
            }
            return nombrePiloto;
        }

        public _avion avionActual
        {
            get;
            set;
        }

        public static int Actualizar(_avion pAvion)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("Update avion set avi_tipo='{1}', pil_id ='{2}' where avi_id = '{0}'", pAvion.avi_id, pAvion.avi_tipo, pAvion.pil_id), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int Eliminar(int id)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("delete from avion where avi_id = '{0}'", id), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
