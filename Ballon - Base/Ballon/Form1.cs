using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ballon
{
    public partial class frmBallon : Form
    {
        int time = 0;
        
        public frmBallon()
        {
            InitializeComponent();
        }

        private void tmrTicTac_Tick(object sender, EventArgs e)
        {
            //lb_1.Text = time++.ToString();
        }

        private void frmBallon_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            Random X = new Random();
            Random Y = new Random();

            pctBallon.Visible = true;
            //Le ballon pourtant avec une position random reste sur le même axe en permanece mais sa pos sur cet axe est random
            pctBallon.Location = new Point(X.Next(0,327), Y.Next(50,275));
            lb_1.Text=(X.Next(0, 327).ToString() + " " + Y.Next(50, 275).ToString());
        }
    }
}
