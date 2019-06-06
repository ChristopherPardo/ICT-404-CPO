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
            if (LB_Bord.Items.Count == 0)
            {
                BT_Retrait.Enabled = false;
            }

            if (LB_Terre.Items.Count == 0)
            {
                BT_Ajout.Enabled = false;
            }
        }


        private void BT_Ajout_Click(object sender, EventArgs e)
        {
            if (LB_Terre.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez selectionner un animal à terre");
                return;
            }
            LB_Bord.Items.Add(LB_Terre.SelectedItem);
            LB_Terre.Items.RemoveAt(LB_Terre.SelectedIndex);
            if (LB_Terre.Items.Count == 0)
            {
                BT_Ajout.Enabled = false;
            }
            else
            {
                BT_Ajout.Enabled = true;
            }
        }


        private void BT_Retrait_Click(object sender, EventArgs e)
        {
            if (LB_Terre.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez selectionner un animal à bord");
                return;
            }
            LB_Terre.Items.Add(LB_Bord.SelectedItem);
            LB_Bord.Items.RemoveAt(LB_Bord.SelectedIndex);
            if (LB_Bord.Items.Count == 0)
            {
                BT_Retrait.Enabled = false;
            }
            else
            {
                BT_Retrait.Enabled = true;
            }
        }
    }
}
