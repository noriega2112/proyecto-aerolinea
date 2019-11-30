using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_aerolinea
{
    public class _destino
    {
        public int dest_id { get; set; }
        public string dest_nom { get; set; }

        public _destino() { }

        public _destino (int id, string nombreDestino)
        {
            this.dest_id = id;
            this.dest_nom = nombreDestino;
        }
    }
}
