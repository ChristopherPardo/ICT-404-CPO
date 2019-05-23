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
        const int Dist = 12;
        const int LongBT = 111;
        const int LargBT = 39;
        Rectangle scr;
        int X;
        int Y;
        int XBT;
        int YBT;
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
            X = scr.Width - this.Width;
            Y = scr.Height - this.Height;
        }

        private void Bt_HG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0,0);
        }

        private void Bt_HD_Click(object sender, EventArgs e)
        {
            this.Location = new Point(X,0);
        }

        private void Bt_BG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, Y);
        }

        private void Bt_BD_Click(object sender, EventArgs e)
        {
            
            this.Location = new Point(X,Y);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int MaxX = this.Width - 16;
            int MaxY = this.Height - 40;
            X = scr.Width - this.Width;
            Y = scr.Height - this.Height;
            XBT = MaxX - LargBT - Dist;
            YBT = MaxY - LongBT - Dist;
            


            Bt_HG.Location = new Point(Dist,Dist);
            Bt_HD.Location = new Point(XBT,Dist);
            Bt_BG.Location = new Point(Dist,YBT);
            Bt_BD.Location = new Point(XBT,YBT);
        }
    }
}
