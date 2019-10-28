using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_aerolinea
{
    public partial class boleto : Form
    {
        public boleto()
        {
            InitializeComponent();

            if (Usuario.tipo != "administrador")
                eliminarbtn.Visible = false;

        }
    }
}
