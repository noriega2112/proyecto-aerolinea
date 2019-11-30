using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_aerolinea
{
    public class _empleado
    {
        public int emp_id { get; set; }
        public string emp_nom { get; set; }
        public string emp_ape { get; set; }
        public string emp_fecna { get; set; }
        public string emp_genero { get; set; }
        public string emp_dir { get; set; }
        public string emp_colbo { get; set; }
        public string emp_tel { get; set; }



        public _empleado() { }
        public void DataSource() { }
        public _empleado(int _id, string _emp_nom, string _emp_ape, string _emp_fecna, string _emp_genero, string _emp_dir, string _emp_colbo, string _emp_tel)
        {
            this.emp_id = _id;
            this.emp_nom = _emp_nom;
            this.emp_ape = _emp_ape;
            this.emp_fecna = _emp_fecna;
            this.emp_genero = _emp_genero;
            this.emp_dir = _emp_dir;
            this.emp_colbo = _emp_colbo;
            this.emp_tel = _emp_tel;
        }
    }
}
