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
    public partial class menu : Form
    {
        string usuario;
        public menu(string pusuario = "admin")
        {
            InitializeComponent();

            this.usuario = pusuario;
        }

        private Form formActivo = null;
        private void abrirHijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel2.Controls.Add(formHijo);
            panel2.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
            panel4.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            abrirHijo(new pasajero());
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}