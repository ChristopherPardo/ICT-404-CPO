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
        int NBTable;
        string Pate;
        string Garn;
        public Form1()
        {
            InitializeComponent();
            TB_Com.Enabled = false;
        }

        private void BT_Com_Click(object sender, EventArgs e)
        {
            

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
                Garn = "Anchois";
            }
            if (CB_Cap.Checked == true)
            {
                Garn = "Câpres";
            }
            if (CB_Cap.Checked == true)
            {
                Garn = "Jambon";
            }
            if (CB_Cap.Checked == true)
            {
                Garn = "Crevettes"; //continuer les checks Boxes (les if son copié colé donc verifie les variables) et met les dans la text box en bas
            }

            TB_Com.Text = "Pour la " + NBTable + " :" + Environment.NewLine + "Pâte " + Pate + " avec ";
        }
    
    }
}
