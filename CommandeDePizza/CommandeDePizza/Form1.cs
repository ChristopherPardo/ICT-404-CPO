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
        }

        private void BT_Com_Click(object sender, EventArgs e)
        {
            int NBTable;

            if (!int.TryParse(TB_Table.Text, out NBTable){
                MessageBox.Show("Veuillez entrer un numéro de table");
            }

            if (RD_E.Checked == true)
            {

            }
            else if(RD_F.Checked == true){

            }
            else if (RD_N.Checked == true){

            }
            else if (RD_EF.Checked == true){

            }
            else{

            }
        }
    
    }
}
