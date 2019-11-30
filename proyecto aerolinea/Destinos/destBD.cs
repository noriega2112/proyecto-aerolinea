using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace proyecto_aerolinea
{
    public class destBD
    {

        public static int Agregar(_destino pDestino)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("Insert into destino(dest_nom) values('{0}')", pDestino.dest_nom), BdConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static _destino obtenerDestino(int dest_id)
        {
            _destino pDestino = new _destino();
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select * from destino where dest_id ='{0}'", dest_id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pDestino.dest_id = _reader.GetInt16(0);
                pDestino.dest_nom = _reader.GetString(1);
            }
            conexion.Close();
            return pDestino;
        }



        public static List<_destino> BuscarT()
        {

            List<_destino> _lista = new List<_destino>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select dest_id as 'ID', dest_nom as 'Nombre del destino' from destino;"), BdConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                _destino pDestino = new _destino();
                pDestino.dest_id = _reader.GetInt16(0);
                pDestino.dest_nom = _reader.GetString(1);
                _lista.Add(pDestino);
            }
            return _lista;
        }



        public static _destino buscarDestino(string dest_nom)
        {
            _destino pDestino = new _destino();
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select * from destino where dest_nom ='{0}'", dest_nom), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pDestino.dest_id = _reader.GetInt16(0);
                pDestino.dest_nom = _reader.GetString(1);
            }
            conexion.Close();
            return pDestino;
        }


        public _destino destinoActual
        {
            get;
            set;
        }

        public static int Actualizar(_destino pDestino)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("Update destino set dest_nom='{1}' where dest_id = '{0}'", pDestino.dest_id, pDestino.dest_nom), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int Eliminar(int id)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("delete from destino where dest_id = '{0}'", id), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}

