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
        int scr;
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
            Screen.PrimaryScreen.Bounds.Width
        }
    }
}
