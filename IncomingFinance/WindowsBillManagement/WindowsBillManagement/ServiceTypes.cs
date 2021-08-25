using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBillManagement
{
    public partial class ServiceTypes : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nwidthEllipse,
                int nHightEllipse
            );

        public ServiceTypes()
        {
            InitializeComponent();
        }

        private void servicePriceDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelT.Text = DateTime.Now.ToLongTimeString();
            labelD.Text = DateTime.Now.ToLongDateString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ServiceTypes_Load(object sender, EventArgs e)
        {
            serviceTypeSaveBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, serviceTypeSaveBtn.Width, serviceTypeSaveBtn.Height, 5, 5));
        }
    }
}
