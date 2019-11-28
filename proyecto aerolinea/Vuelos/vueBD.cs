using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace proyecto_aerolinea
{
    class vueBD
    {
        public static int Agregar(_vuelo pVuelo)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("Insert into vuelo(vue_fecha, avi_id) values('{0}', '{1}')", pVuelo.vue_fecha, pVuelo.avi_id), BdConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static _vuelo obtenerVuelo(int vue_id)
        {
            _vuelo pVuelo = new _vuelo();
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select * from vuelo where vue_id ='{0}'", vue_id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pVuelo.vue_id = _reader.GetInt16(0);
                pVuelo.vue_fecha = _reader.GetString(1);
                pVuelo.avi_id = _reader.GetInt16(2);
            }
            conexion.Close();
            return pVuelo;
        }



        public static List<_vuelo> BuscarT()
        {

            List<_vuelo> _lista = new List<_vuelo>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select vue_id as 'ID', vue_fecha as 'Fecha del vuelo', avi_id as 'Id del avión' from vuelo;"), BdConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                _vuelo pVuelo = new _vuelo();
                pVuelo.vue_id = _reader.GetInt16(0);
                pVuelo.vue_fecha = _reader.GetString(1);
                pVuelo.avi_id = _reader.GetInt16(2);
                _lista.Add(pVuelo);
            }
            return _lista;
        }



        public static int totalVuelos()
        {
            _vuelo pVuelo = new _vuelo();
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select count(*) from vuelo;"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pVuelo.totalDeVuelos = _reader.GetInt16(0);
            }
            conexion.Close();
            return pVuelo.totalDeVuelos;
        }


        public _vuelo vueloActual
        {
            get;
            set;
        }

        public static int Actualizar(_vuelo pVuelo)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("Update vuelo set vue_fecha='{1}', avi_id ='{2}' where vue_id = '{0}'", pVuelo.vue_id, pVuelo.vue_fecha, pVuelo.avi_id), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int Eliminar(int id)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("delete from vuelo where vue_id = '{0}'", id), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
