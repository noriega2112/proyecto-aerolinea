using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_aerolinea
{
    public class _vuelo
    {
        public int vue_id { get; set; }
        public string vue_fecha { get; set; }
        public int avi_id { get; set; }

        public int totalDeVuelos { get; set; }
        public _vuelo () { }

        public _vuelo(int idVuelo, string fechaVuelo, int idAvion, int total)
        {
            this.vue_id = idVuelo;
            this.vue_fecha = fechaVuelo;
            this.avi_id = idAvion;
            this.totalDeVuelos = total;
        }
    }
}
