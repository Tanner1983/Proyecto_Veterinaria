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
    public partial class Jaulas : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public Jaulas()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=pr_titulo;user=root;Pwd='';SslMode=none");
        }

        private void Jaulas_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from pt_tbjaula", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtjaulas.DataSource = ds.Tables[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            administracion ss = new administracion();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            id.Text = "";
            med.Text = "";
            dis.Text = "Si";
            des.Text = "";            
        }

        private void ing_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO pt_tbjaula(id_jaula,med_jaula,des_jaula) VALUES(@id,@nombre,@des)";
            cmd = new MySqlCommand(sql, con);

            //ADD PARAMETERS
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@nombre", med.Text);
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
            dtjaulas.DataSource = "";
            MySqlDataAdapter da = new MySqlDataAdapter("select * from pt_tbjaula", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtjaulas.DataSource = ds.Tables[0];
        }

        private void dtjaulas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Enabled = false;
            id.Text = Convert.ToString(dtjaulas.Rows[dtjaulas.CurrentCellAddress.Y].Cells[0].Value);
            med.Text = Convert.ToString(dtjaulas.Rows[dtjaulas.CurrentCellAddress.Y].Cells[1].Value);
            dis.Text = Convert.ToString(dtjaulas.Rows[dtjaulas.CurrentCellAddress.Y].Cells[2].Value);
            des.Text = Convert.ToString(dtjaulas.Rows[dtjaulas.CurrentCellAddress.Y].Cells[3].Value);
        }

        private void el_Click(object sender, EventArgs e)
        {
            int ids = Convert.ToInt32(id.Text);
            delete(ids);
        }

        private void delete(int id)
        {
            //SQLSTMT
            string sql = "DELETE FROM pt_tbjaula WHERE id_jaula=" + id + "";
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
            string name = med.Text;
            string desc = des.Text;
            update(ids, name, desc);
        }

        private void update(int id, string name, string des)
        {
            //SQL STMT
            string sql = "UPDATE pt_tbjaula SET med_jaula='" + name + "',des_especiejaula='" + des + "' WHERE id_jaula=" + id + "";
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

        private void jaulasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
