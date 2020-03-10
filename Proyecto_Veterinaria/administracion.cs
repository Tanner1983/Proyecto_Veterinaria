using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Veterinaria
{
    public partial class administracion : Form
    {
        public administracion()
        {
            InitializeComponent();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void especiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Especies ss = new Especies();
            ss.Show();
        }
    }
}
