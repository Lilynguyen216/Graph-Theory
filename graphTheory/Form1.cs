using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphTheory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoThi_Click(object sender, EventArgs e)
        {
            frmGraph graph = new frmGraph();
            graph.Show();
            this.Hide();
        }

        private void btnMaTran_Click(object sender, EventArgs e)
        {
            frmMatrix matrix = new frmMatrix();
            matrix.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
