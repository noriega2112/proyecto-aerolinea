using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_aerolinea
{
    public class _pasajero
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string fechaDeNacimiento { get; set; }
        public string genero { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }

        

        public _pasajero() { }
        public void DataSource() { }
        public _pasajero(int _id, string _pas_nom, string _pas_ape, string _pas_fecna, string _pas_genero, string _pas_email, string _pas_tel)
        {
            this.id = _id;
            this.nombre = _pas_nom;
            this.apellido = _pas_ape;
            this.fechaDeNacimiento = _pas_fecna;
            this.genero = _pas_genero;
            this.email = _pas_email;
            this.telefono = _pas_tel;
        }
    }                    
}                        
