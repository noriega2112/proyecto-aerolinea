using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_aerolinea
{
    class _boleto
    {
        public int pas_id { get; set; }
        public string bol_fecha { get; set; }
        public int dest_id { get; set; }
        public int vue_id { get; set; }
        public int bol_costo { get; set; }

        public _boleto(int _pas_id, string _bol_fecha, int _dest_id, int _vue_id, int _bol_costo)
        {
            this.pas_id = _pas_id;
            this.bol_fecha = _bol_fecha;
            this.dest_id = _dest_id;
            this.vue_id = _vue_id;
            this.bol_costo = _bol_costo;
        }
    }
}
