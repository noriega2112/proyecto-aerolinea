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
    public partial class formDestino : Form
    {
        public formDestino()
        {
            InitializeComponent();

            if (Usuario.tipo != "administrador")
                eliminarbtn.Visible = false;
        }

        bool validar()
        {
            if (string.IsNullOrWhiteSpace(destNom.Text))
            {
                error.SetError(destNom, "Ingrese un destino");
                return false;
            }
            else
                return true;
        }

        void limpiar()
        {
            destNom.Clear();
        }

        public _destino VueloActual { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _destino pDestino = new _destino();
                pDestino.dest_nom = destNom.Text.Trim();

                int resultado = destBD.Agregar(pDestino);
                if (resultado > 0)
                {
                    MessageBox.Show("Destino Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error.Clear();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el destino", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void consultarbtn_Click(object sender, EventArgs e)
        {
            error.Clear();
            buscarDestino buscar = new buscarDestino();
            buscar.ShowDialog();
            if (buscar.destinoSeleccionado != null)
            {
                VueloActual = buscar.destinoSeleccionado;
                destNom.Text = buscar.destinoSeleccionado.dest_nom;
                
                ingresarbtn.Hide();
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _destino pDestino = new _destino();
                pDestino.dest_id = VueloActual.dest_id;
                pDestino.dest_nom = destNom.Text.Trim();

                if (destBD.Actualizar(pDestino) > 0)
                {
                    MessageBox.Show("Los datos del destino se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            
                int id = VueloActual.dest_id;

                if (destBD.Eliminar(id) > 0)
                {
                    error.Clear();
                    MessageBox.Show("Los datos del destino se eliminaron", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
