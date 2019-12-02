using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace proyecto_aerolinea
{
    class bolBD
    {
        public static int Agregar(_boleto pBoleto)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("Insert into boleto(pas_id, bol_fecha, dest_id, vue_id, bol_costo) values('{0}','{1}','{2}','{3}','{4}')", pBoleto.pas_id, pBoleto.bol_fecha, pBoleto.dest_id, pBoleto.vue_id, pBoleto.bol_costo), BdConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static _boleto obtenerBoleto(int bol_id)
        {
            _boleto pBoleto = new _boleto();
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select * from boleto where bol_id ='{0}'", bol_id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pBoleto.bol_id = _reader.GetInt16(0);
                pBoleto.pas_id = _reader.GetInt16(1);
                pBoleto.bol_fecha = _reader.GetString(2);
                pBoleto.dest_id = _reader.GetInt16(3);
                pBoleto.vue_id = _reader.GetInt16(4);
                pBoleto.bol_costo = _reader.GetInt16(5);
            }
            conexion.Close();
            return pBoleto;
        }
        public static string nombrePasajero(int pas_id)
        {
            string nombrePas = "";
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select pas_nom, pas_ape from boleto, pasajero where boleto.pas_id = pasajero.pas_id AND bol_id='{0}'", pas_id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                nombrePas = _reader.GetString(0) + ' '  + _reader.GetString(1);
            }
            conexion.Close();
            return nombrePas;
        }



        public static List<_boleto> BuscarT()
        {

            List<_boleto> _lista = new List<_boleto>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select bol_id as 'ID', pas_id as 'Id Pasajero', bol_fecha as 'Fecha de Boleto', dest_id as 'Id Destino', vue_id as 'Id Vuelo', bol_costo as 'Costo de boleto' from boleto;"), BdConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                _boleto pBoleto = new _boleto();
                pBoleto.bol_id = _reader.GetInt16(0);
                pBoleto.pas_id = _reader.GetInt16(1);
                pBoleto.bol_fecha = _reader.GetString(2);
                pBoleto.dest_id = _reader.GetInt16(3);
                pBoleto.vue_id = _reader.GetInt16(4);
                pBoleto.bol_costo = _reader.GetInt16(5);
                _lista.Add(pBoleto);
            }
            return _lista;
        }



        public static List<_boleto> Buscar(string pDestino)
        {
            List<_boleto> _lista = new List<_boleto>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select * from boleto where dest_id like '%{0}%'", pDestino), BdConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                _boleto pBoleto = new _boleto();
                pBoleto.bol_id = _reader.GetInt16(0);
                pBoleto.pas_id = _reader.GetInt16(1);
                pBoleto.bol_fecha = _reader.GetString(2);
                pBoleto.dest_id = _reader.GetInt16(3);
                pBoleto.vue_id = _reader.GetInt16(4);
                pBoleto.bol_costo = _reader.GetInt16(5);
                _lista.Add(pBoleto);
            }
            return _lista;
        }


        public _boleto boletoActual
        {
            get;
            set;
        }

        public static int Actualizar(_boleto pBoleto)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("Update boleto set pas_id='{1}',bol_fecha='{2}',dest_id='{3}',vue_id='{4}',bol_costo='{5}' where bol_id = '{0}'", pBoleto.bol_id, pBoleto.pas_id, pBoleto.bol_fecha, pBoleto.dest_id, pBoleto.vue_id, pBoleto.bol_costo), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int Eliminar(int id)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("delete from boleto where pas_id = '{0}'", id), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
