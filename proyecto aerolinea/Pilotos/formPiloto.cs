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
    public partial class formPiloto : Form
    {
        public formPiloto()
        {
            InitializeComponent();

            if (Usuario.tipo != "administrador")
                eliminarbtn.Visible = false;
        }

        bool validar()
        {
            if (string.IsNullOrWhiteSpace(licenciatxt.Text))
            {
                error.SetError(licenciatxt, "Ingrese una licencia.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(certificadotxt.Text))
            {
                error.SetError(certificadotxt, "Ingrese un certificado.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(horastxt.Text) || Convert.ToInt16(horastxt.Text) < 0)
            {
                error.SetError(horastxt, "Ingrese las horas de vuelo.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(idEmpleadotxt.Text))
            {
                error.SetError(idEmpleadotxt, "Seleccione un empleado.");
                return false;
            }
            else
                return true;
        }

        void limpiar()
        {
            licenciatxt.Clear();
            certificadotxt.Clear();
            horastxt.Clear();
            trackBar1.Value = 0;
            idEmpleadotxt.Clear();
            nombreEmpleado.Clear();
            prueba.Text = Convert.ToString(trackBar1.Value);
        }

        public _piloto pilotoActual { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _piloto pPiloto = new _piloto();
                pPiloto.pil_lic = licenciatxt.Text.Trim();
                pPiloto.pil_certm = certificadotxt.Text.Trim();
                pPiloto.pil_horas = Convert.ToInt16(horastxt.Text);
                pPiloto.emp_id = Convert.ToInt16(idEmpleadotxt.Text);
                pPiloto.pil_calif = Convert.ToInt16(trackBar1.Value);

                int resultado = pilBD.Agregar(pPiloto);
                if (resultado > 0)
                {
                    MessageBox.Show("Piloto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error.Clear();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el piloto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void consultarbtn_Click(object sender, EventArgs e)
        {
            error.Clear();
            buscarPiloto buscar = new buscarPiloto();
            buscar.ShowDialog();
            if (buscar.pilotoSeleccionado != null)
            {
                pilotoActual = buscar.pilotoSeleccionado;
                licenciatxt.Text = pilotoActual.pil_lic;
                certificadotxt.Text = pilotoActual.pil_certm;
                horastxt.Text = Convert.ToString(pilotoActual.pil_horas);
                trackBar1.Value = pilotoActual.pil_calif;
                idEmpleadotxt.Text = Convert.ToString(pilotoActual.pil_id);
                nombreEmpleado.Text = pilBD.nombreEmpleado(pilotoActual.pil_id);
                ingresarbtn.Hide();
                idEmpleadotxt.Enabled = false;
                prueba.Text = Convert.ToString(trackBar1.Value);
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _piloto pPiloto = new _piloto();
                pPiloto.pil_id = pilotoActual.pil_id;
                pPiloto.pil_lic = licenciatxt.Text.Trim();
                pPiloto.pil_certm = certificadotxt.Text.Trim();
                pPiloto.pil_horas = Convert.ToInt16(horastxt.Text);
                pPiloto.emp_id = Convert.ToInt16(idEmpleadotxt.Text);
                pPiloto.pil_calif = Convert.ToInt16(trackBar1.Value);

                if (pilBD.Actualizar(pPiloto) > 0)
                {
                    MessageBox.Show("Los datos del piloto se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            
                int id = pilotoActual.pil_id;

                if (pilBD.Eliminar(id) > 0)
                {
                    error.Clear();
                    MessageBox.Show("Los datos del piloto se eliminaron", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            prueba.Text = Convert.ToString(trackBar1.Value);
            idEmpleadotxt.Enabled = false;
        }

        private void nombretxt_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            prueba.Text = Convert.ToString(trackBar1.Value);
        }

        private void empleadobtn_Click(object sender, EventArgs e)
        {
            buscarEmpleado piloto = new buscarEmpleado();
            piloto.ShowDialog();

            if (piloto.empleadoSeleccionado != null)
            {
                nombreEmpleado.Text = piloto.empleadoSeleccionado.emp_nom;
                idEmpleadotxt.Text = Convert.ToString(piloto.empleadoSeleccionado.emp_id);
            }
            
        }
    }
}
