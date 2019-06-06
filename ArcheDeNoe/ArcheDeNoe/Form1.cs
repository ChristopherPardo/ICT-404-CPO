using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheDeNoe
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

        private void LB_Bord_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if () ;
            
        }

        private void BT_Ajout_Click(object sender, EventArgs e)
        {
            LB_Bord.Items.Add(LB_Terre.SelectedItem);
            LB_Terre.Items.RemoveAt(LB_Terre.SelectedIndex);
        }
    }
}
