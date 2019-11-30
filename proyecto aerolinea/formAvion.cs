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
    public partial class formAvion : Form
    {
        public formAvion()
        {
            InitializeComponent();

            if (Usuario.tipo != "administrador")
                eliminarbtn.Visible = false;
        }

        bool validar()
        {
            if (string.IsNullOrWhiteSpace(tipotxt.Text))
            {
                error.SetError(tipotxt, "Seleccione un tipo de avión ");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(idPiloto.Text))
            {
                error.SetError(idPiloto, "Seleccione un piloto");
                return false;
            }
            else
                return true;
        }

        void limpiar()
        {
            idPiloto.Clear();
            tipotxt.Clear();
        }

        public _avion avionActual { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _avion pAvion = new _avion();
                pAvion.avi_tipo = tipotxt.Text.Trim();
                pAvion.pil_id = Convert.ToInt16(idPiloto.Text.Trim());

                int resultado = aviBD.Agregar(pAvion);
                if (resultado > 0)
                {
                    MessageBox.Show("Avión Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error.Clear();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el avion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void consultarbtn_Click(object sender, EventArgs e)
        {
            error.Clear();
            buscarAvion buscar = new buscarAvion();
            buscar.ShowDialog();
            if (buscar.avionSeleccionado != null)
            {
                avionActual = buscar.avionSeleccionado;
                idPiloto.Text = Convert.ToString(buscar.avionSeleccionado.pil_id);
                idPiloto.Text = buscar.avionSeleccionado.avi_tipo;
                
                ingresarbtn.Hide();
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _avion pAvion = new _avion();
                pAvion.avi_id = avionActual.avi_id;
                pAvion.avi_tipo = tipotxt.Text.Trim();
                pAvion.pil_id = Convert.ToInt16(idPiloto.Text.Trim());

                if (aviBD.Actualizar(pAvion) > 0)
                {
                    MessageBox.Show("Los datos del avión se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            
                int id = avionActual.avi_id;

                if (aviBD.Eliminar(id) > 0)
                {
                    error.Clear();
                    MessageBox.Show("Los datos del avión se eliminaron", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void nombretxt_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }
    }
}
