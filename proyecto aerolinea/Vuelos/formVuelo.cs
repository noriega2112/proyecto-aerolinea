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
    public partial class formVuelo : Form
    {
        public formVuelo()
        {
            InitializeComponent();

            if (Usuario.tipo != "administrador")
                eliminarbtn.Visible = false;
        }

        bool validar()
        {
            if (string.IsNullOrWhiteSpace(idAviontxt.Text))
            {
                error.SetError(idAviontxt, "Seleccione un avión .");
                return false;
            }
            else
                return true;
        }

        void limpiar()
        {
            idAviontxt.Clear();
            dtp.ResetText();
        }

        public _vuelo VueloActual { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _vuelo pVuelo = new _vuelo();
                pVuelo.avi_id = Convert.ToInt16(idAviontxt.Text.Trim());
                pVuelo.vue_fecha = dtp.Value.ToString("yyyy-MM-dd");

                int resultado = vueBD.Agregar(pVuelo);
                if (resultado > 0)
                {
                    MessageBox.Show("Vuelo Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error.Clear();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Vuelo", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void consultarbtn_Click(object sender, EventArgs e)
        {
            error.Clear();
            buscarVuelo buscar = new buscarVuelo();
            buscar.ShowDialog();
            if (buscar.vueloSeleccionado != null)
            {
                VueloActual = buscar.vueloSeleccionado;
                idAviontxt.Text = Convert.ToString(buscar.vueloSeleccionado.avi_id);
                dtp.Text = buscar.vueloSeleccionado.vue_fecha;
                
                ingresarbtn.Hide();
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _vuelo pVuelo = new _vuelo();
                pVuelo.vue_id = VueloActual.vue_id;
                pVuelo.avi_id = Convert.ToInt16(idAviontxt.Text.Trim());
                pVuelo.vue_fecha = dtp.Value.ToString("yyyy-MM-dd");

                if (vueBD.Actualizar(pVuelo) > 0)
                {
                    MessageBox.Show("Los datos del vuelo se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            
                int id = VueloActual.vue_id;

                if (vueBD.Eliminar(id) > 0)
                {
                    error.Clear();
                    MessageBox.Show("Los datos del vuelo se eliminaron", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
