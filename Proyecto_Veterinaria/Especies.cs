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
    public partial class Especies : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public Especies()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=pr_titulo;user=root;Pwd='';SslMode=none");
        }

        private void Especies_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from pt_tbespecie", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtespecies.DataSource = ds.Tables[0];
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void esp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void des_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void ing_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO pt_tbespecie(id_especie,nom_especie,des_especie) VALUES(@id,@nombre,@des)";
            cmd = new MySqlCommand(sql, con);

            //ADD PARAMETERS
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@nombre",esp.Text);
            cmd.Parameters.AddWithValue("@des", des.Text);
            //OPEN CON AND EXEC insert
            try
            {
                con.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    id.Text="";
                    esp.Text = "";
                    des.Text = "";
                    MessageBox.Show("Successfully Inserted");
                }

                con.Close();

                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void retrieve()
        {
            dtespecies.DataSource="";
            MySqlDataAdapter da = new MySqlDataAdapter("select * from pt_tbespecie", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtespecies.DataSource = ds.Tables[0];
        }
    }
}
