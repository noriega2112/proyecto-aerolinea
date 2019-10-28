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

namespace proyecto_aerolinea
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            usuario.Clear();
            contra.Clear();
            usuario.Focus();
            this.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usuario.Text))
            {
                ep1.SetError(usuario, "Ingrese un usuario");
            }
            else if (string.IsNullOrEmpty(contra.Text))
            {
                ep1.SetError(contra, "Ingrese una contraseña");
            }
            else
            {

                DataTable tabla = new DataTable();
                MySqlCommand comando = new MySqlCommand(string.Format("select * from usuario where nombre='{0}' and contra='{1}'", usuario.Text, contra.Text), BdConexion.ObtenerConexion());
                //MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                //adaptador.Fill(tabla);
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Usuario.nombre = reader.GetString(0);
                        Usuario.contra = reader.GetString(1);
                        Usuario.tipo = reader.GetString(2);
                    }
                    Form menu = new menu();
                    menu.Show();
                    menu.FormClosed += Logout;
                    this.Hide();
                    //if (tabla.Rows[0][1].ToString() == "administrador")
                    //{
                    //    Form menu = new menu("admin");
                    //    menu.Show();
                    //    this.Hide();
                    //}
                    //else if (tabla.Rows[0][1].ToString() == "vendedor")
                    //{
                    //    Form menu = new menu("vendedor");
                    //    menu.Show();
                    //    this.Hide();
                    //}
                }
                else
                {
                    MessageBox.Show("Este usuario no está registrado", "Usuario no existe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuario.Clear();
                    contra.Clear();
                    usuario.Focus();
                }
            }
        }

        private void Usuario_MouseClick(object sender, MouseEventArgs e)
        {
            ep1.Clear();
        }

        private void Contra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1.PerformClick();
            }
        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                contra.Focus();
            }
        }
    }
}
