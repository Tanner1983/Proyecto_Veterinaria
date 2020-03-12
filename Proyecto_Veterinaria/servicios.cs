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
    public partial class servicios : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public servicios()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=pr_titulo;user=root;Pwd='';SslMode=none");
        }

        private void volver_Click(object sender, EventArgs e)
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
            nom.Text = "";
            pre.Text = "Si";
            des.Text = "";
        }

        private void servicios_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select id_serv,nomb_serv,prec_serv,desc_serv from pt_tbservicio", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtservicios.DataSource = ds.Tables[0];
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            servicios ss = new servicios();
            ss.Show();
        }        

        private void dtservicios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id.Enabled = false;
            id.Text = Convert.ToString(dtservicios.Rows[dtservicios.CurrentCellAddress.Y].Cells[0].Value);
            nom.Text = Convert.ToString(dtservicios.Rows[dtservicios.CurrentCellAddress.Y].Cells[1].Value);
            pre.Text = Convert.ToString(dtservicios.Rows[dtservicios.CurrentCellAddress.Y].Cells[2].Value);
            des.Text = Convert.ToString(dtservicios.Rows[dtservicios.CurrentCellAddress.Y].Cells[3].Value);
        }
    }
}
