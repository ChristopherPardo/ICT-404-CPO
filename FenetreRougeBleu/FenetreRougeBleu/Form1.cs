/*
 * Christopher Pardo
 * 20.05.2019
 * FenetreRougeBleu
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

namespace FenetreRougeBleu
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Rectangle scr;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Bt_bleu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Bt_Rouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scr = Screen.GetBounds(this);
        }

        private void Bt_HG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0,0);
        }

        private void Bt_HD_Click(object sender, EventArgs e)
        {
            this.Location = new Point(scr.Height,0);
        }

        private void Bt_BG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, scr.Width);
        }

        private void Bt_BD_Click(object sender, EventArgs e)
        {
            this.Location = new Point(scr.Height - this.Height, scr.Width - this.Width);//verifie la soustraction on dirait que on ne peut pas soustraire
        }
    }
}
