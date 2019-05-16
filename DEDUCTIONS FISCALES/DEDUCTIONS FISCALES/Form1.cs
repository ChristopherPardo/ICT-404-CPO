using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace DEDUCTIONS_FISCALES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            float brut;
            float familial;
            float fidel;
            if(!float.TryParse(textBox3.Text,out brut))
            {
                MessageBox.Show("Veuillez-entrer un chiffre");
                textBox3.Focus();
                return;
            }
            if (!float.TryParse(textBox5.Text, out familial))
            {
                MessageBox.Show("Veuillez-entrer un chiffre");
                textBox5.Focus();
                return;
            }
            if (brut < 2000)
            {
                MessageBox.Show("Vous ne pouvez pas avoir un salaire brut annuel inférieur à 2'000");//Faire que le calcule ne soit pas fait sir < 2000
            }
            float total = brut / familial;
            
            if(checkBox3.Checked){
                if (!float.TryParse(textBox1.Text, out fidel))
                {
                    MessageBox.Show("Veuillez-entrer un chiffre");
                    textBox1.Focus();
                    return;
                }
                else
                {
                    total -=  fidel / 100 * total;
                }
            }
            
            
            if(total < 0)
            {
                total = 0;
                MessageBox.Show("Vous ne pouvez pas devoir une somme négative");
            }
            label3.Text = "Revenu imposable : " + total.ToString();
        }

        

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }
    }
}
