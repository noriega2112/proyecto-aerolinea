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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

            //label1.Text = "Bienvenido, " + Usuario.nombre.ToUpper();
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
            abrirHijo(new formPasajero());
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            abrirHijo(new formBoleto());
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cerrarSesionbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar sesión?", "Alerta",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirHijo(new formVuelo());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            abrirHijo(new formDestino());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirHijo(new formEmpleado());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirHijo(new formAvion());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirHijo(new formPiloto());

        }
    }
}
