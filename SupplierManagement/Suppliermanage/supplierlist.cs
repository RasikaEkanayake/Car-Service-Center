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

namespace Suppliermanage
{
    public partial class supplierlist : Form
    {
        Supplierform form;

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
        public supplierlist()
        {
            InitializeComponent();
            form = new Supplierform(this);
        }

        public void Display()
        {
            dbsupplier.DisplaySupplier("SELECT sup_id, companyname, address, country, contactnumber, email, paymenttype, itemtype, description, date FROM suppliermanage", dataGridView1);
        }
        private void suppliermanage_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            buttonview.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonview.Width, buttonview.Height, 30, 30));
            buttonadd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonadd.Width, buttonadd.Height, 30, 30));

            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
            label1.Text = DateTime.Now.ToLongDateString();


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sup1_Click(object sender, EventArgs e)
        {

        }




        private void textBox2_TextChanged(object sender, EventArgs e)
            
        {
            dbsupplier.DisplaySupplier("SELECT sup_id, companyname, address, country, contactnumber, email, paymenttype, itemtype, description, date FROM suppliermanage WHERE date LIKE'%" + textsearch.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }



        private void buttonadd_Click(object sender, EventArgs e)
        {
            form.clear();
            new Supplierform(this).ShowDialog();
        }

        private void buttonview_Click(object sender, EventArgs e)
        {
            new Supplierprofile().ShowDialog();
        }

        private void supplierlist_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 0)
            {
                //edit button click
                form.clear();
                form.sup_id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.companyname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.address = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.country = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.contactnumber = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.email = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.paymenttype = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.itemtype = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.description = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.date= dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;


                //edit

            }
            if(e.ColumnIndex == 1)
            {
             if(MessageBox.Show("Do you want to delete Supplier Record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
           
                    dbsupplier.DeleteSupplier(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //dbsupplier.UpdateSupplire();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            new Form1sup().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new supplierlist().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new supreport().ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objBmp, -237, 200);

            e.Graphics.DrawString(sup1.Text, new Font("century gothic", 24, FontStyle.Regular), Brushes.Blue, new Point(200, 60));
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}









