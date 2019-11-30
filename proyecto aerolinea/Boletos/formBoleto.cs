using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace proyecto_aerolinea
{
    public partial class formBoleto : Form
    {
        public formBoleto()
        {
            InitializeComponent();

            if (Usuario.tipo != "administrador")
                eliminarbtn.Visible = false;
        }

        bool validar()
        {
            if (string.IsNullOrWhiteSpace(pasajerotxt.Text))
            {
                error.SetError(pasajerotxt, "Ingrese un pasajero.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cmbDestino.Text))
            {
                error.SetError(cmbDestino, "Seleccione un destino.");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(costotxt.Text))
            {
                error.SetError(costotxt, "Ingrese un costo.");
                return false;
            }
            else
                return true;
        }

        void limpiar()
        {
            pasajerotxt.Clear();
            dtp.ResetText();
            costotxt.Clear();
            idVuelo.Text = Convert.ToString(rand());
            cmbDestino.ResetText();
            idDestino.Clear();
            idPasajero.Clear();
        }

        int rand()
        {
            int vuelosTotales = vueBD.totalVuelos();
            Random rnd = new Random();
            int n = rnd.Next(1, vuelosTotales+1);  // crea un numero aleatorio entre 1 y el total de vuelos registrados
            return n;
        }

        public _boleto BoletoActual { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _boleto pBoleto = new _boleto();
                pBoleto.bol_fecha = dtp.Value.ToString("yyyy-MM-dd");
                pBoleto.pas_id = Convert.ToInt16(idPasajero.Text);
                pBoleto.dest_id = Convert.ToInt16(idDestino.Text);
                pBoleto.vue_id = Convert.ToInt16(idVuelo.Text);
                pBoleto.bol_costo = Convert.ToInt16(costotxt.Text.Trim());

                int resultado = bolBD.Agregar(pBoleto);
                if (resultado > 0)
                {
                    MessageBox.Show("Boleto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error.Clear();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el boleto", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void consultarbtn_Click(object sender, EventArgs e)
        {
            error.Clear();
            buscarBoleto buscar = new buscarBoleto();
            buscar.ShowDialog();
            if (buscar.boletoSeleccionado != null)
            {
                BoletoActual = buscar.boletoSeleccionado;
                string nombrePasajero = pasBD.obtenerPasajero(buscar.boletoSeleccionado.pas_id).nombre; //utilizar pasBD para obtener el nombre del pasajero seleccionado
                idPasajero.Text = Convert.ToString(buscar.boletoSeleccionado.pas_id);
                pasajerotxt.Text = nombrePasajero;
                dtp.Text = buscar.boletoSeleccionado.bol_fecha;
                idDestino.Text = Convert.ToString(buscar.boletoSeleccionado.dest_id);
                costotxt.Text = Convert.ToString(buscar.boletoSeleccionado.bol_costo);
                
                ingresarbtn.Hide();
            }
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                _boleto pBoleto = new _boleto();
                pBoleto.bol_id = BoletoActual.bol_id;
                pBoleto.bol_fecha = dtp.Value.ToString("yyyy-MM-dd");
                pBoleto.dest_id = Convert.ToInt16(idDestino.Text);
                pBoleto.pas_id = Convert.ToInt16(idPasajero.Text);
                pBoleto.vue_id = Convert.ToInt16(idVuelo.Text);
                pBoleto.bol_costo = Convert.ToInt16(costotxt.Text.Trim());

                if (bolBD.Actualizar(pBoleto) > 0)
                {
                    MessageBox.Show("Los datos del boleto se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            
                int id = BoletoActual.bol_id;

                if (bolBD.Eliminar(id) > 0)
                {
                    error.Clear();
                    MessageBox.Show("Los datos del boleto se eliminaron", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            idVuelo.Enabled = false;
            idDestino.Enabled = false;
            DataTable tabla = new DataTable();

            string query = "Select dest_id, dest_nom from destino;";
            using (MySqlConnection conexion = BdConexion.ObtenerConexion())
            {
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                adaptador.Fill(tabla);
            }

            cmbDestino.DataSource = tabla;
            cmbDestino.ValueMember = "dest_id";
            cmbDestino.DisplayMember = "dest_nom";

            

            idVuelo.Text = Convert.ToString(rand());
            
        }

        private void cmbDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            _destino dest = destBD.buscarDestino(cmbDestino.Text);
            idDestino.Text = Convert.ToString(dest.dest_id);

        }

        private void pasajerotxt_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void pasajerobtn_Click(object sender, EventArgs e)
        {
            buscarPasajero pasajero = new buscarPasajero();
            pasajero.ShowDialog();

            if (pasajero.pasajeroSeleccionado != null)
            {
                pasajerotxt.Text = pasajero.pasajeroSeleccionado.nombre;
                idPasajero.Text = Convert.ToString(pasajero.pasajeroSeleccionado.id);
            }
            else
                pasajerotxt.Clear();
            
        }

        private void costotxt_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
