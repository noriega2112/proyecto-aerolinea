using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_aerolinea
{
    public class _avion
    {
        public int avi_id { get; set; }
        public string avi_tipo { get; set; }
        public int pil_id { get; set; }
        
        public _avion() { }

        public _avion(int idAvion, string tipo, int idPiloto)
        {
            this.avi_id = idAvion;
            this.avi_tipo = tipo;
            this.pil_id = idPiloto;
        }
    }
}
