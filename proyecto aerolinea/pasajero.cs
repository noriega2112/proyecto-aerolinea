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
    public partial class pasajero : Form
    {
        public pasajero()
        {
            InitializeComponent();


            if(Usuario.tipo != "administrador")
                eliminarbtn.Visible = false;

            cmbGenero.Text = "Masculino";
        }

        void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dtpFecna.ResetText();
            cmbGenero.ResetText();
        }

        bool validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                error.SetError(txtNombre, "Ingrese un Nombre.");
                return false;

            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                error.SetError(txtApellido, "Ingrese un Apellido.");
                return false;

            }
            else if (string.IsNullOrWhiteSpace(cmbGenero.Text))
            {
                error.SetError(cmbGenero, "Ingrese un género.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                error.SetError(txtEmail, "Ingrese un email.");
                return false;
            }
            
            else if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                error.SetError(txtTelefono, "Ingrese un número de telefono.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Pasajero_Load(object sender, EventArgs e)
        {

        }

        private void Ingresarbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
           
        }

        private Form formActivo = null;
        private void abrirHijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = true;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            //panel1.Controls.Add(formHijo);
            //panel1.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.ShowDialog();
            panel1.BringToFront();
        }

        private void consultarbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ingresarbtn_Click_1(object sender, EventArgs e)
        {
            if (validar())
            {
                _pasajero pPasajero = new _pasajero();
                pPasajero.nombre = txtNombre.Text.Trim();
                pPasajero.apellido = txtApellido.Text.Trim();
                pPasajero.fechaDeNacimiento = dtpFecna.Value.ToString("yyyy-MM-dd");
                pPasajero.genero = cmbGenero.Text.Trim();
                pPasajero.email = txtEmail.Text.Trim();
                pPasajero.telefono = txtTelefono.Text.Trim();

                int resultado = pasBd.Agregar(pPasajero);
                if (resultado > 0)
                {
                    MessageBox.Show("Pasajero Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error.Clear();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el pasajero", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public _pasajero pasajeroActual{ get; set; }

        private void consultarbtn_Click_1(object sender, EventArgs e)
        {
            error.Clear();
            buscarPasajero frm = new buscarPasajero();
            abrirHijo(frm);
            //frm.ShowDialog();
            if (frm.pasajeroSeleccionado != null)
            {
                pasajeroActual = frm.pasajeroSeleccionado;
                txtNombre.Text = pasajeroActual.nombre;
                txtApellido.Text = pasajeroActual.apellido;
                dtpFecna.Text = pasajeroActual.fechaDeNacimiento;
                cmbGenero.Text = pasajeroActual.genero;
                txtEmail.Text = pasajeroActual.email;
                txtTelefono.Text = pasajeroActual.telefono;
            }
        }

        private void modificarbtn_Click_1(object sender, EventArgs e)
        {
            if (validar())
            {
                _pasajero pPasajero = new _pasajero();
                label1.Text = pPasajero.id.ToString();
                pPasajero.nombre = txtNombre.Text.Trim();
                pPasajero.apellido = txtApellido.Text.Trim();
                pPasajero.fechaDeNacimiento = dtpFecna.Value.ToString("yyyy-MM-dd");
                pPasajero.genero = cmbGenero.Text.Trim();
                pPasajero.email = txtEmail.Text.Trim();
                pPasajero.telefono = txtTelefono.Text.Trim();

                int resultado = pasBd.Actualizar(pPasajero);
                if (resultado > 0)
                {
                    MessageBox.Show("Pasajero modificado Con Exito!!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error.Clear();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el pasajero", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }
    }
}
