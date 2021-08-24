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

namespace StockManagemnt
{
    public partial class Form1 : Form
    {
        //fix rectangle to curve
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




        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //get add details form as pop up
            new Form2().ShowDialog();

        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            //maximized to full screen
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w,h);

            //get the date and time
            timer1.Start();

            //buttons' border changing to curve
            button1.Region=Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //get new items needs to by table as pop up
            new Form3().ShowDialog();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //get date and time
            label1.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                //close button
                DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

        }
    }
}
