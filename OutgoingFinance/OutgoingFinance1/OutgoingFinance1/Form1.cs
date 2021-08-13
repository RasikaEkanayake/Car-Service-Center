﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutgoingFinance1
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fix rectangle curves
            button1.Region=Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));

            timer1.Start();
            label1.Text = DateTime.Now.ToShortTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        //Adding hovers to button
        private void button1_Mousehover(object sender, EventArgs e)
        {
            button1.BackColor = Color.GreenYellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
        }

        private void button2_Mousehover(object sender, EventArgs e)
        {
            button2.BackColor = Color.OrangeRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.WhiteSmoke;
        }

        private void button3_Mousehover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Orange;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.WhiteSmoke;
        }

        private void button4_Mousehover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.WhiteSmoke;
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
