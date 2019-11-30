using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace proyecto_aerolinea
{
    class empleBD
    {
        public static int Agregar(_empleado pEmpleado)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(String.Format("Insert into empleado(emp_nom, emp_ape, emp_fecna, emp_genero, emp_dir, emp_colbo, emp_tel) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", pEmpleado.emp_nom, pEmpleado.emp_ape, pEmpleado.emp_fecna, pEmpleado.emp_genero, pEmpleado.emp_dir, pEmpleado.emp_colbo, pEmpleado.emp_tel), BdConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static _empleado obtenerEmpleado(int pemp_id)
        {
            _empleado pEmpleado = new _empleado();
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select * from empleado where emp_id ='{0}'", pemp_id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pEmpleado.emp_id = _reader.GetInt16(0);
                pEmpleado.emp_nom = _reader.GetString(1);
                pEmpleado.emp_ape = _reader.GetString(2);
                pEmpleado.emp_fecna= _reader.GetString(3);
                pEmpleado.emp_genero = _reader.GetString(4);
                pEmpleado.emp_dir = _reader.GetString(5);
                pEmpleado.emp_colbo = _reader.GetString(6);
                pEmpleado.emp_tel = _reader.GetString(7);
            }
            conexion.Close();
            return pEmpleado;
        }



        public static List<_empleado> BuscarT()
        {

            List<_empleado> _lista = new List<_empleado>();
            MySqlCommand _comando = new MySqlCommand(String.Format("Select emp_id as 'ID', emp_nom as 'Nombre', emp_ape as 'Apellido', emp_fecna as 'Nacimiento', emp_genero as 'Género', emp_dir as 'Dirección', emp_colbo as 'Bo. / Col.', emp_tel as 'Teléfono' from empleado"), BdConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                _empleado pEmpleado = new _empleado();
                pEmpleado.emp_id = _reader.GetInt16(0);
                pEmpleado.emp_nom = _reader.GetString(1);
                pEmpleado.emp_ape = _reader.GetString(2);
                pEmpleado.emp_fecna = _reader.GetString(3);
                pEmpleado.emp_genero = _reader.GetString(4);
                pEmpleado.emp_dir = _reader.GetString(5);
                pEmpleado.emp_colbo = _reader.GetString(6);
                pEmpleado.emp_tel = _reader.GetString(7);
                _lista.Add(pEmpleado);
            }
            return _lista;
        }



        //public static List<_empleado> Buscar(string pnombre)
        //{
        //    List<_empleado> _lista = new List<_empleado>();
        //    MySqlCommand _comando = new MySqlCommand(String.Format("Select * from pasajero where pas_nom like '%{0}%'", pnombre), BdConexion.ObtenerConexion());
        //    MySqlDataReader _reader = _comando.ExecuteReader();
        //    while (_reader.Read())
        //    {
        //        _empleado pEmpleado = new _empleado();
        //        pEmpleado.id = _reader.GetInt16(0);
        //        pEmpleado.nombre = _reader.GetString(1);
        //        pEmpleado.apellido = _reader.GetString(2);
        //        pEmpleado.fechaDeNacimiento = _reader.GetString(3);
        //        pEmpleado.genero = _reader.GetString(4);
        //        pEmpleado.email = _reader.GetString(5);
        //        pEmpleado.telefono = _reader.GetString(6);
        //        _lista.Add(pEmpleado);
        //    }
        //    return _lista;
        //}


        public _empleado empleadoActual
        {
            get;
            set;
        }

        public static int Actualizar(_empleado pEmpleado)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("Update empleado set emp_nom='{1}',emp_ape='{2}',emp_fecna='{3}',emp_genero='{4}',emp_dir='{5}',emp_colbo='{6}',emp_tel='{7}' where emp_id = '{0}'", pEmpleado.emp_id, pEmpleado.emp_nom, pEmpleado.emp_ape, pEmpleado.emp_fecna, pEmpleado.emp_genero, pEmpleado.emp_dir, pEmpleado.emp_colbo, pEmpleado.emp_tel), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int Eliminar(int id)
        {
            int retorno = 0;
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("delete from empleado where emp_id = '{0}'", id), conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
