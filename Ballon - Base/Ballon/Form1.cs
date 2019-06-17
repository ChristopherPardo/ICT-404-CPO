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
            lb_1.Text = time++.ToString();
        }

        private void frmBallon_Load(object sender, EventArgs e)
        {
            
        }
    }
}
