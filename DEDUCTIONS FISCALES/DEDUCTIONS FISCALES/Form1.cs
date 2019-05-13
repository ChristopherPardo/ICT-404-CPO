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

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            float brut;
            float familial;
            if(!float.TryParse(textBox3.Text,out brut))
            {
                MessageBox.Show("Veuillez-entrer un chiffre");
                textBox3.Focus();
            }
            if (!float.TryParse(textBox5.Text, out familial))
            {
                MessageBox.Show("Veuillez-entrer un chiffre");
                textBox5.Focus();
            }
            float total = brut / familial;
            label3.Text = "Revenu imposable : " + total.ToString();
            
        }
    }
}
