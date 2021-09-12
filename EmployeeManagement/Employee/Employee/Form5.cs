using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            Rating Rating = new Rating();
            Rating.ShowDialog();
        }
    }
}
