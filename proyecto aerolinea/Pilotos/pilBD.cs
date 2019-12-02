using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace proyecto_aerolinea
{
    class pilBD
    {
        public static int Agregar(_piloto pPiloto)
        {
            int retorno = 0;
        MySqlCommand comando = new MySqlCommand(String.Format("Insert into piloto(pil_lic, pil_certm, pil_horas, pil_calif, emp_id) values('{0}','{1}','{2}','{3}','{4}')", pPiloto.pil_lic, pPiloto.pil_certm, pPiloto.pil_horas, pPiloto.pil_calif, pPiloto.emp_id), BdConexion.ObtenerConexion());
        retorno = comando.ExecuteNonQuery();
            return retorno;
        }

    public static _piloto obtenerPiloto(int pil_id)
    {
        _piloto pPiloto = new _piloto();
        MySqlConnection conexion = BdConexion.ObtenerConexion();
        MySqlCommand _comando = new MySqlCommand(String.Format("select * from piloto where pil_id ='{0}'", pil_id), conexion);
        MySqlDataReader _reader = _comando.ExecuteReader();
        while (_reader.Read())
        {
            pPiloto.pil_id = _reader.GetInt16(0);
            pPiloto.pil_lic = _reader.GetString(1);
            pPiloto.pil_certm = _reader.GetString(2);
            pPiloto.pil_horas = _reader.GetInt16(3);
            pPiloto.pil_calif = _reader.GetInt16(4);
            pPiloto.emp_id = _reader.GetInt16(5);
        }
        conexion.Close();
        return pPiloto;
    }

        public static string nombreEmpleado(int id)
        {
            string nombreEmpleado = "";
            MySqlConnection conexion = BdConexion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select emp_nom from empleado, piloto where empleado.emp_id = piloto.emp_id AND pil_id='{0}'", id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                nombreEmpleado = _reader.GetString(0);
            }
            conexion.Close();
            return nombreEmpleado;
        }

        public static List<_piloto> BuscarT()
    {

        List<_piloto> _lista = new List<_piloto>();
        MySqlCommand _comando = new MySqlCommand(String.Format("Select pil_id as 'ID', pil_lic as 'Licencia', pil_certm as 'Certificado Médico', pil_horas as 'Horas de vuelo', pil_calif as 'Calificacíón', emp_id as 'Id empleado' from piloto"), BdConexion.ObtenerConexion());
        MySqlDataReader _reader = _comando.ExecuteReader();
        while (_reader.Read())
        {
            _piloto pPiloto = new _piloto();
                pPiloto.pil_id = _reader.GetInt16(0);
                pPiloto.pil_lic = _reader.GetString(1);
                pPiloto.pil_certm = _reader.GetString(2);
                pPiloto.pil_horas = _reader.GetInt16(3);
                pPiloto.pil_calif = _reader.GetInt16(4);
                pPiloto.emp_id = _reader.GetInt16(5);
            
            _lista.Add(pPiloto);
        }
        return _lista;
    }



    //public static List<_piloto> Buscar(string pnombre)
    //{
    //    List<_piloto> _lista = new List<_piloto>();
    //    MySqlCommand _comando = new MySqlCommand(String.Format("Select * from pasajero where pas_nom like '%{0}%'", pnombre), BdConexion.ObtenerConexion());
    //    MySqlDataReader _reader = _comando.ExecuteReader();
    //    while (_reader.Read())
    //    {
    //        _piloto pPiloto = new _piloto();
    //        pPiloto.id = _reader.GetInt16(0);
    //        pPiloto.nombre = _reader.GetString(1);
    //        pPiloto.apellido = _reader.GetString(2);
    //        pPiloto.fechaDeNacimiento = _reader.GetString(3);
    //        pPiloto.genero = _reader.GetString(4);
    //        pPiloto.email = _reader.GetString(5);
    //        pPiloto.telefono = _reader.GetString(6);
    //        _lista.Add(pPiloto);
    //    }
    //    return _lista;
    //}


    public _piloto pilotoActual
    {
        get;
        set;
    }

    public static int Actualizar(_piloto pPiloto)
    {
        int retorno = 0;
        MySqlConnection conexion = BdConexion.ObtenerConexion();
        MySqlCommand comando = new MySqlCommand(String.Format("Update piloto set pil_lic ='{1}', pil_certm='{2}',pil_horas='{3}',pil_calif='{4}',emp_id='{5}' where pil_id = '{0}'", pPiloto.pil_id, pPiloto.pil_lic, pPiloto.pil_certm, pPiloto.pil_horas, pPiloto.pil_calif, pPiloto.emp_id), conexion);
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }

    public static int Eliminar(int id)
    {
        int retorno = 0;
        MySqlConnection conexion = BdConexion.ObtenerConexion();
        MySqlCommand comando = new MySqlCommand(String.Format("delete from piloto where pil_id = '{0}'", id), conexion);
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }
}
}
