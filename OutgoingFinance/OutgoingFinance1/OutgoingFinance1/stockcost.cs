using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OutgoingFinance1
{
    public partial class stockcost : Form
    {
        public stockcost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addcost addcost = new addcost();
            addcost.Show();
        }
    }
}
