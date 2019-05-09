using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExoBonjour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (blName.Text == "")
            {
                btBienvenue.Enabled = false;
            }
            else
            {
                btBienvenue.Enabled = true;
            }
        }

        private void btBienvenue_Click(object sender, EventArgs e)
        {
            rp.Text = "Bonjour " + blName.Text;
            blName.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
