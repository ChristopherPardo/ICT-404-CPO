using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineACalculer
{
    public partial class Form1 : Form
    {

        float Premier = 0;
        float Deuxieme = 0;
        float Resultat = 0;
        bool First = true;

        private void calcule(int nombre)
        {

            if (Premier < 10)
            {
                if (First == true)
                {
                    Premier += nombre;
                }
                else
                {
                    Deuxieme += nombre;
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas entrer un chiffre supperieur à 99");
                return;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BT_1_Click(object sender, EventArgs e)
        {
            calcule(1);
        }

        private void BT_2_Click(object sender, EventArgs e)
        {

        }

        private void BT_3_Click(object sender, EventArgs e)
        {

        }

        private void BT_4_Click(object sender, EventArgs e)
        {

        }

        private void BT_5_Click(object sender, EventArgs e)
        {

        }

        private void BT_6_Click(object sender, EventArgs e)
        {

        }

        private void BT_7_Click(object sender, EventArgs e)
        {

        }

        private void BT_8_Click(object sender, EventArgs e)
        {

        }

        private void BT_9_Click(object sender, EventArgs e)
        {

        }

        private void BT_0_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
