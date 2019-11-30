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
    public partial class formEmpleado : Form
    {
        public formEmpleado()
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
            else if (string.IsNullOrWhiteSpace(apellidotxt.Text))
            {
                error.SetError(apellidotxt, "Ingrese un apellido.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cmbgenero.Text))
            {
                error.SetError(cmbgenero, "Seleccione un género.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(direcciontxt.Text))
            {
                error.SetError(direcciontxt, "Ingrese una dirección.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(colbotxt.Text))
            {
                error.SetError(colbotxt, "Ingrese un barrio o colonia.");
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
            colbotxt.Clear();
            direcciontxt.Clear();
            teltxt.Clear();
        }

        public _empleado empleadoActual { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _empleado pEmpleado = new _empleado();
                pEmpleado.emp_nom = nombretxt.Text.Trim();
                pEmpleado.emp_ape = apellidotxt.Text.Trim();
                pEmpleado.emp_fecna= dtp.Value.ToString("yyyy-MM-dd");
                pEmpleado.emp_genero = cmbgenero.Text;
                pEmpleado.emp_dir = direcciontxt.Text.Trim();
                pEmpleado.emp_colbo = colbotxt.Text.Trim();
                pEmpleado.emp_tel = teltxt.Text.Trim();

                int resultado = empleBD.Agregar(pEmpleado);
                if (resultado > 0)
                {
                    MessageBox.Show("Empleado Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error.Clear();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el empleado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void consultarbtn_Click(object sender, EventArgs e)
        {
            error.Clear();
            buscarEmpleado buscar = new buscarEmpleado();
            buscar.ShowDialog();
            if (buscar.empleadoSeleccionado != null)
            {
                empleadoActual = buscar.empleadoSeleccionado;
                nombretxt.Text = buscar.empleadoSeleccionado.emp_nom;
                apellidotxt.Text = buscar.empleadoSeleccionado.emp_ape;
                dtp.Text = buscar.empleadoSeleccionado.emp_fecna;
                cmbgenero.Text = buscar.empleadoSeleccionado.emp_genero;
                direcciontxt.Text = buscar.empleadoSeleccionado.emp_dir;
                colbotxt.Text = buscar.empleadoSeleccionado.emp_colbo;
                teltxt.Text = buscar.empleadoSeleccionado.emp_tel;
                
                ingresarbtn.Hide();
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _empleado pEmpleado = new _empleado();
                pEmpleado.emp_id = empleadoActual.emp_id;
                pEmpleado.emp_nom = nombretxt.Text.Trim();
                pEmpleado.emp_ape = apellidotxt.Text.Trim();
                pEmpleado.emp_fecna = dtp.Value.ToString("yyyy-MM-dd");
                pEmpleado.emp_genero = cmbgenero.Text;
                pEmpleado.emp_dir = direcciontxt.Text.Trim();
                pEmpleado.emp_colbo = colbotxt.Text.Trim();
                pEmpleado.emp_tel = teltxt.Text.Trim();

                if (empleBD.Actualizar(pEmpleado) > 0)
                {
                    MessageBox.Show("Los datos del empleado se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            
                int id = empleadoActual.emp_id;

                if (empleBD.Eliminar(id) > 0)
                {
                    error.Clear();
                    MessageBox.Show("Los datos del empleado se eliminaron", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void nombretxt_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }
    }
}
