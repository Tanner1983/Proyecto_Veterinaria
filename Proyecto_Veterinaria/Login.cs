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

namespace Proyecto_Veterinaria
{
    public partial class Login : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Login()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=pr_titulo;user=root;Pwd='';SslMode=none");
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
        }

        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            string user = usuario.Text;
            string pass = contraseña.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM pt_tbusuario where id_usuario='" + usuario.Text + "' AND pas_usuario='" + contraseña.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string[] row = { dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5) };
                int rol = dr.GetInt32(5);
                if (rol == 1)
                {
                    this.Hide();
                    administracion ss = new administracion();
                    ss.Show();
                }
                else if (rol == 2){
                    this.Hide();
                    usuario ss = new usuario();
                    ss.Show();
                }
                else if (rol == 3)
                {
                    this.Hide();
                    medico ss = new medico();
                    ss.Show();
                }
                else if (rol == 4)
                {
                    this.Hide();
                    administracion ss = new administracion();
                    ss.Show();
                }

            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }
    }
}
