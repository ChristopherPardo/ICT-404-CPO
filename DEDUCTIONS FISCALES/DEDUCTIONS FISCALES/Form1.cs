/*
 * Christopher Pardo
 * 20.05.2019
 * Déductions Fiscales
 */

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
            textBox4.Enabled = false;
            textBox2.Enabled = false;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            float brut;
            float familial;
            float fidel;
            float jeune;
            float transport;
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
                MessageBox.Show("Vous ne pouvez pas avoir un salaire brut annuel inférieur à 2'000");
                return;
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
                if (checkBox1.Checked == true)
                {
                    if (!float.TryParse(textBox4.Text, out jeune))
                    {
                        MessageBox.Show("Veuillez-entrer un chiffre");
                        textBox4.Focus();
                        return;
                    }
                    else
                    {
                        total -= jeune;
                    }
                }
                if (checkBox2.Checked == true)
                {
                    if (!float.TryParse(textBox2.Text, out transport))
                    {
                        MessageBox.Show("Veuillez-entrer un chiffre");
                        textBox2.Focus();
                        return;
                    }
                    else
                    {
                        total -= transport;
                    }
                }
                
            }
            
            
            
            
            if(total < 0)
            {
                MessageBox.Show("Vous ne pouvez pas devoir une somme négative");
                textBox1.Focus();
                return;
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

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
            }
        }
    }
}
