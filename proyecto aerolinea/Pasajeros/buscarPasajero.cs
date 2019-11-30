using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace proyecto_aerolinea
{
    public partial class buscarPasajero : Form
    {
        public buscarPasajero()
        {
            InitializeComponent();
        }
        

        private void buscarPasajero_Load(object sender, EventArgs e)
        {
            void cargar()
            {
                DataTable tabla = new DataTable();

                string query = "Select pas_id as 'ID', pas_nom as 'Nombre', pas_ape as 'Apellido', pas_fecna as 'Nacimiento', pas_genero as 'Género', pas_email as 'Email', pas_tel as 'Telefono' from pasajero;";
                using (MySqlConnection conexion = BdConexion.ObtenerConexion())
                {
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion);
                    adaptador.Fill(tabla);
                }
                
                dataGridView1.DataSource = tabla;
            }

            cargar();
            
        }

        public _pasajero pasajeroSeleccionado { get; set; }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int linea = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                pasajeroSeleccionado = pasBD.obtenerPasajero(linea);
                this.Close();
            }
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de regresar?", "Alerta",
             MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
