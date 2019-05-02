using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenue
{
    public partial class frmBienvenue : Form
    {
        public frmBienvenue()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblBienvenueDate1.Text = string.Format("{0:dd MMM yyyy}", DateTime.Now);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
