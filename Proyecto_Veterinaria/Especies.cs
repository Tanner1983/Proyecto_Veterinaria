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
                    limpiar();
                    MessageBox.Show("Agregado Correctamente");
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

        private void limpiar()
        {
            id.Text = "";
            esp.Text = "";
            des.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            administracion ss = new administracion();
            ss.Show();
        }

        private void dtespecies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Enabled = false;
            id.Text = Convert.ToString(dtespecies.Rows[dtespecies.CurrentCellAddress.Y].Cells[0].Value);
            esp.Text = Convert.ToString(dtespecies.Rows[dtespecies.CurrentCellAddress.Y].Cells[1].Value);
            des.Text = Convert.ToString(dtespecies.Rows[dtespecies.CurrentCellAddress.Y].Cells[2].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void el_Click(object sender, EventArgs e)
        {
            int ids = Convert.ToInt32(id.Text);
            delete(ids);
        }

        private void delete(int id)
        {
            //SQLSTMT
            string sql = "DELETE FROM pt_tbespecie WHERE id_especie=" + id + "";
            cmd = new MySqlCommand(sql, con);

            //'OPEN CON,EXECUTE DELETE,CLOSE CON
            try
            {
                con.Open();
                MessageBox.Show(con.State.ToString());
                adapter = new MySqlDataAdapter(cmd);

                adapter.DeleteCommand = con.CreateCommand();

                adapter.DeleteCommand.CommandText = sql;

                //PROMPT FOR CONFIRMATION
                if (MessageBox.Show("Estas seguro ??", "Borrar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        limpiar();
                        MessageBox.Show("Eliminado Correctamente");
                    }
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

        private void mod_Click(object sender, EventArgs e)
        {
            int ids = Convert.ToInt32(id.Text);
            string name = esp.Text;
            string desc = des.Text;
            update(ids,name,desc);
        }

        private void update(int id, string name, string des)
        {
            //SQL STMT
            string sql = "UPDATE pt_tbespecie SET nom_especie='" + name + "',des_especie='" + des + "' WHERE id_especie=" + id + "";
            cmd = new MySqlCommand(sql, con);

            //OPEN CON,UPDATE,RETRIEVE DGVIEW
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);

                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    limpiar();
                    MessageBox.Show("Actualizado Correctamente");
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
    }
}
