﻿using System;
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
    public partial class pasajero : Form
    {
        public pasajero()
        {
            InitializeComponent();


            if(Usuario.tipo != "administrador")
                eliminarbtn.Visible = false;
        }

        private void Pasajero_Load(object sender, EventArgs e)
        {

        }
    }
}
