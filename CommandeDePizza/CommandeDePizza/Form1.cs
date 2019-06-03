using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandeDePizza
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            TB_Com.Enabled = false;
        }

        private void BT_Com_Click(object sender, EventArgs e)
        {
            int NBTable;
            string Pate;
            string Garn = "";
            if (!int.TryParse(TB_Table.Text, out NBTable))
            {
                MessageBox.Show("Veuillez entrer un numéro de table");
                return;
            }

            if (RD_E.Checked == true)
            {
                Pate = "Épaisse";
            }
            else if(RD_F.Checked == true)
            {
                Pate = "Fine";
            }
            else if (RD_N.Checked == true)
            {
                Pate = "Normale";
            }
            else if (RD_EF.Checked == true)
            {
                Pate = "Extra-fine";
            }
            else
            {
                MessageBox.Show("Veuillez choisir une épaisseur de pâte");
                return;
            }

            if (CB_A.Checked == true)
            {
                Garn = "des anchois";
            }
            if (CB_Cap.Checked == true)
            {
                if (Garn != "")
                {
                   Garn += ", ";
                }
                Garn += "des câpres";
            }
            if (CB_J.Checked == true)
            {
                if (Garn != "")
                {
                    Garn += ", ";
                }
                Garn += "du jambon";
            }
            if (CB_Crev.Checked == true)
            {
                if (Garn != "")
                {
                    Garn += ", ";
                }
                Garn += "des crevettes";
            }
            if (CB_A.Checked == false && CB_Cap.Checked == false && CB_J.Checked == false && CB_Crev.Checked == false)
            {
                Garn = "Aucune garniture";
            }

            TB_Com.Text = "Pour la " + NBTable + " :" + Environment.NewLine + "Pâte " + Pate + " avec " + Environment.NewLine + Garn;
        }
    
    }
}
