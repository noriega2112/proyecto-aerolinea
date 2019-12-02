using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_aerolinea
{
    public class _piloto
    {
        public int pil_id { get; set; }
        public string pil_lic { get; set; }
        public string pil_certm { get; set; }
        public int pil_horas { get; set; }
        public int pil_calif { get; set; }
        public int emp_id { get; set; }

        public _piloto() { }

        public _piloto(int _pil_id, string _pil_lic, string _pil_certm, int _pil_horas, int _pil_calif, int _emp_id)
        {
            this.pil_id = _pil_id;
            this.pil_lic = _pil_lic;
            this.pil_certm = _pil_certm;
            this.pil_horas = _pil_horas;
            this.pil_calif = _pil_calif;
            this.emp_id = _emp_id;
        }

    }
}
