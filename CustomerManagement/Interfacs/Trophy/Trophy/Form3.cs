using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Trophy
{
    public partial class Form3 : Form
    {
        //fix rectangle curves
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

        public Form3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
            btnpSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnpSave.Width, btnpSave.Height, 12,12));
            btnpDelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnpDelete.Width, btnpDelete.Height, 12,12));
            btnpUpdate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnpUpdate.Width, btnpUpdate.Height, 12,12));
       

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show("Do you really want to exit from the profile?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
