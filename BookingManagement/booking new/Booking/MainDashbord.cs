using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Booking
{
    public partial class MainDashbord : Form
    {
        public MainDashbord()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new BK_Main().ShowDialog();
        }

        private void x_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
