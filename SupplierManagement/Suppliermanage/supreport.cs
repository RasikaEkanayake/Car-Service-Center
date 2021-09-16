using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suppliermanage
{
    public partial class supreport : Form
    {
        public supreport()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new supplierlist().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                new supplierlist().ShowDialog();
            }
        }
    }
}
