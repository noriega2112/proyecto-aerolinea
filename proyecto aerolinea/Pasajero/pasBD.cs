using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace proyecto_aerolinea
{
    public class pasBD
    {
        public static int Agregar(_pasajero pPasajero)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("Insert into pasajero(pas_nom, pas_ape, pas_fecna, pas_genero, pas_email, pas_tel) values('{0}','{1}','{2}','{3}','{4}','{5}')", pPasajero.nombre, pPasajero.apellido, pPasajero.fechaDeNacimiento, pPasajero.genero, pPasajero.email, pPasajero.telefono), BdConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static _pasajero obtenerPasajero(int ppas_id)
        {
            _pasajero pPasajero = new _pasajero();
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select * from pasajero where pas_id ='{0}'", ppas_id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pPasajero.id = _reader.GetInt16(0);
                pPasajero.nombre = _reader.GetString(1);
                pPasajero.apellido = _reader.GetString(2);
                pPasajero.fechaDeNacimiento = _reader.GetString(3);
                pPasajero.genero = _reader.GetString(4);
                pPasajero.email = _reader.GetString(5);
                pPasajero.telefono = _reader.GetString(6);
            }
            conexion.Close();
            return pPasajero;
        }



        public static List<_pasajero> BuscarT()
        {
            
        List<_pasajero> _lista = new List<_pasajero>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select pas_id as 'ID', pas_nom as 'Nombre', pas_ape as 'Apellido', pas_fecna as 'Nacimiento', pas_genero as 'Género', pas_email as 'Email', pas_tel as 'Telefono' from pasajero "), BdConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                _pasajero pPasajero = new _pasajero();
                pPasajero.id = _reader.GetInt16(0);
                pPasajero.nombre = _reader.GetString(1);
                pPasajero.apellido = _reader.GetString(2);
                pPasajero.fechaDeNacimiento = _reader.GetString(3);
                pPasajero.genero = _reader.GetString(4);
                pPasajero.email = _reader.GetString(5);
                pPasajero.telefono = _reader.GetString(6);
                _lista.Add(pPasajero);
            }
            return _lista;
        }

        

        public static List<_pasajero> Buscar(string pnombre)
        {
            List<_pasajero> _lista = new List<_pasajero>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select * from pasajero where pas_nom like '%{0}%'", pnombre), BdConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                _pasajero pPasajero = new _pasajero();
                pPasajero.id = _reader.GetInt16(0);
                pPasajero.nombre = _reader.GetString(1);
                pPasajero.apellido = _reader.GetString(2);
                pPasajero.fechaDeNacimiento = _reader.GetString(3);
                pPasajero.genero = _reader.GetString(4);
                pPasajero.email = _reader.GetString(5);
                pPasajero.telefono = _reader.GetString(6);
                _lista.Add(pPasajero);
            }
            return _lista;
        }
        

        public _pasajero pasajeroActual
        {
            get;
            set;
        }

        public static int Actualizar(_pasajero pPasajero)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("Update pasajero set pas_nom='{1}',pas_ape='{2}',pas_fecna='{3}',pas_genero='{4}',pas_email='{5}',pas_tel='{6}' where pas_id = '{0}'",pPasajero.id, pPasajero.nombre, pPasajero.apellido, pPasajero.fechaDeNacimiento, pPasajero.genero, pPasajero.email, pPasajero.telefono), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int Eliminar(int id)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("delete from pasajero where pas_id = '{0}'", id), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
