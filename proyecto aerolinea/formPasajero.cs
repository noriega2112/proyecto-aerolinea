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
    public partial class formPasajero : Form
    {
        public formPasajero()
        {
            InitializeComponent();

            if (Usuario.tipo != "administrador")
                eliminarbtn.Visible = false;
        }

        bool validar()
        {
            if (string.IsNullOrWhiteSpace(nombretxt.Text))
            {
                error.SetError(nombretxt, "Ingrese un nombre.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cmbgenero.Text))
            {
                error.SetError(cmbgenero, "Seleccione un género.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(emailtxt.Text))
            {
                error.SetError(emailtxt, "Ingrese un email.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(teltxt.Text))
            {
                error.SetError(teltxt, "Ingrese un número de telefono.");
                return false;
            }
            else
                return true;
        }

        void limpiar()
        {
            nombretxt.Clear();
            apellidotxt.Clear();
            dtp.ResetText();
            cmbgenero.Text = "Masculino";
            teltxt.Clear();
            emailtxt.Clear();
        }

        public _pasajero PasajeroActual { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _pasajero pPasajero = new _pasajero();
                pPasajero.nombre = nombretxt.Text.Trim();
                pPasajero.apellido = apellidotxt.Text.Trim();
                pPasajero.fechaDeNacimiento = dtp.Value.ToString("yyyy-MM-dd");
                pPasajero.genero = cmbgenero.Text;
                pPasajero.email = emailtxt.Text.Trim();
                pPasajero.telefono = teltxt.Text.Trim();

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

        private void consultarbtn_Click(object sender, EventArgs e)
        {
            error.Clear();
            buscarPasajero buscar = new buscarPasajero();
            buscar.ShowDialog();
            if (buscar.pasajeroSeleccionado != null)
            {
                PasajeroActual = buscar.pasajeroSeleccionado;
                nombretxt.Text = buscar.pasajeroSeleccionado.nombre;
                apellidotxt.Text = buscar.pasajeroSeleccionado.apellido;
                dtp.Text = buscar.pasajeroSeleccionado.fechaDeNacimiento;
                cmbgenero.Text = buscar.pasajeroSeleccionado.genero;
                emailtxt.Text = buscar.pasajeroSeleccionado.email;
                teltxt.Text = buscar.pasajeroSeleccionado.telefono;
                
                ingresarbtn.Hide();
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _pasajero pPasajero = new _pasajero();
                pPasajero.id = PasajeroActual.id;
                pPasajero.nombre = nombretxt.Text.Trim();
                pPasajero.apellido = apellidotxt.Text.Trim();
                pPasajero.fechaDeNacimiento = dtp.Value.ToString("yyyy-MM-dd");
                pPasajero.genero = cmbgenero.Text;
                pPasajero.email = emailtxt.Text.Trim();
                pPasajero.telefono = teltxt.Text.Trim();

                if (pasBd.Actualizar(pPasajero) > 0)
                {
                    MessageBox.Show("Los datos del pasajero se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error.Clear();
                    limpiar();
                    ingresarbtn.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            
            
                int id = PasajeroActual.id;

                if (pasBd.Eliminar(id) > 0)
                {
                    error.Clear();
                    MessageBox.Show("Los datos del pasajero se eliminaron", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error.Clear();
                    limpiar();
                    ingresarbtn.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        private void formPasajero_Load(object sender, EventArgs e)
        {
            cmbgenero.Text = "Masculino";
        }
    }
}
