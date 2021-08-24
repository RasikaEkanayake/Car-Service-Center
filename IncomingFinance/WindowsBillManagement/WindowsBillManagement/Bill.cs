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
    public partial class Bill : Form
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

        double t1Unit = 20000.00;
        double t2Unit = 12000.00;
        double t3Unit = 5500.00;
        double t4Unit = 10000.00;
        double t5Unit = 8000.00;
        double t6Unit = 25000.00;
        double t7Unit = 13500.00;
        double t8Unit = 14000.00;

        int totq = 0;
        double totp = 0.00;
        int discountR = 50;
        double discount = 0.00;

        public static string setCusID;
        public static string setCusName;
        public static string setVehicleID;
        public static string setDayForm;
        public static string setMonthForm;
        public static string setYearForm;
        public static string setPaymentMethod;
        public static string setPrice;

        public Bill()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            customerIDtxt.Text = "";
            customerNametxt.Text = "";
            vehicleIDtxt.Text = "";
            customerDisctxt.Text = "";

            setDate();

            type1Q.Value = 0;
            type2Q.Value = 0;
            type3Q.Value = 0;
            type4Q.Value = 0;
            type5Q.Value = 0;
            type6Q.Value = 0;
            type7Q.Value = 0;
            type8Q.Value = 0;

            billReceipt.Clear();

            type1P.Text = "Rs 0.00";
            type2P.Text = "Rs 0.00";
            type3P.Text = "Rs 0.00";
            type4P.Text = "Rs 0.00";
            type5P.Text = "Rs 0.00";
            type6P.Text = "Rs 0.00";
            type7P.Text = "Rs 0.00";
            type8P.Text = "Rs 0.00";

            totalP.Text = "Rs 0.00";
            totalQ.Text = "00";
            totalp_d.Text = "Rs 0.00";

            totp = 0.00;
            discount = 0.00;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.ShowDialog();
            }
            catch(Exception ex)
            {
                //Message.Creat(ex.Message, "Bill Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                System.Drawing.Font fntString = new System.Drawing.Font("Arial", 18, FontStyle.Regular);
                e.Graphics.DrawString(billReceipt.Text, fntString, Brushes.Black, 120, 120);
            }
            catch (Exception ex)
            {
                //Message.Creat(ex.Message, "Bill Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void type1Q_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(type1Q.Value);
            i = i*t1Unit;
            String strn = "Rs " + Convert.ToString(i);
            type1P.Text = strn;
        }

        private void type2Q_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(type2Q.Value);
            i = i * t2Unit;
            String strn = "Rs " + Convert.ToString(i);
            type2P.Text = strn;
        }

        private void type3Q_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(type3Q.Value);
            i = i * t3Unit;
            String strn = "Rs " + Convert.ToString(i);
            type3P.Text = strn;
        }

        private void type4Q_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(type4Q.Value);
            i = i * t4Unit;
            String strn = "Rs " + Convert.ToString(i);
            type4P.Text = strn;
        }

        private void type5Q_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(type5Q.Value);
            i = i * t5Unit;
            String strn = "Rs " + Convert.ToString(i);
            type5P.Text = strn;
        }

        private void type6Q_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(type6Q.Value);
            i = i * t6Unit;
            String strn = "Rs " + Convert.ToString(i);
            type6P.Text = strn;
        }

        private void type7Q_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(type7Q.Value);
            i = i * t7Unit;
            String strn = "Rs " + Convert.ToString(i);
            type7P.Text = strn;
        }

        private void type8Q_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(type8Q.Value);
            i = i * t8Unit;
            String strn = "Rs " + Convert.ToString(i);
            type8P.Text = strn;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            totq = Convert.ToInt16(type1Q.Value) + Convert.ToInt16(type2Q.Value) + Convert.ToInt16(type3Q.Value) + Convert.ToInt16(type4Q.Value) + Convert.ToInt16(type5Q.Value) + Convert.ToInt16(type6Q.Value) + Convert.ToInt16(type7Q.Value) + Convert.ToInt16(type8Q.Value);
            totalQ.Text = Convert.ToString(totq);

            totp = Convert.ToInt16(type1Q.Value)*t1Unit + Convert.ToInt16(type2Q.Value)*t2Unit + Convert.ToInt16(type3Q.Value)*t3Unit + Convert.ToInt16(type4Q.Value)*t4Unit + Convert.ToInt16(type5Q.Value)*t5Unit + Convert.ToInt16(type6Q.Value)*t6Unit + Convert.ToInt16(type7Q.Value)*t7Unit + Convert.ToInt16(type8Q.Value)*t8Unit;
            String strn1 = "Rs " + Convert.ToString(totp);
            totalP.Text = strn1;
            totalp_d.Text = strn1;

            if(customerDisctxt.Text == "Yes")
            {
                discount = totp * discountR / 100;
                totp = totp - discount;
                String strn2 = "Rs " + Convert.ToString(totp);
                totalp_d.Text = strn2;
            }
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalQ_Click(object sender, EventArgs e)
        {

        }


        private void priceTaBtn_Click(object sender, EventArgs e)
        {
            new ServiceTypes().ShowDialog();
        }

        private void incomeTaBtn_Click(object sender, EventArgs e)
        {
            new IncomeTable().ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            setCusID = customerIDtxt.Text;
            setCusName = customerNametxt.Text;
            setVehicleID = vehicleIDtxt.Text;
            setDayForm = billDayCombo.Text;
            setMonthForm = billMonthCombo.Text;
            setYearForm = billYearCombo.Text;
            setPaymentMethod = billPayMethodCombo.Text;
            setPrice = Convert.ToString(discount);

            AddNewIncome ani = new AddNewIncome();
            ani.Show();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;

            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);

            //fix rectangle curves
            btnTotal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTotal.Width, btnTotal.Height, 12, 12));
            btnReset.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnReset.Width, btnReset.Height, 12, 12));
            btnSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 12, 12));
            btnReceipt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnReceipt.Width, btnReceipt.Height, 12, 12));
            btnPrint.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPrint.Width, btnPrint.Height, 12, 12));

            getCusD.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, getCusD.Width, getCusD.Height, 5, 5));
            billSetDateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, billSetDateBtn.Width, billSetDateBtn.Height, 5, 5));
            incomeTaBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, incomeTaBtn.Width, incomeTaBtn.Height, 5, 5));
            priceTaBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, priceTaBtn.Width, priceTaBtn.Height, 5, 5));

            timer1.Start();

            billPayMethodCombo.Text = "Select a Payment Method";

            setDate();
        }

        public void setDate()
        {
            String monthNo = DateTime.Now.Month.ToString();
            String monthName = "";
            int monthN = Convert.ToInt32(monthNo);

            if (monthN == 1)
                monthName = "January";
            else if (monthN == 2)
                monthName = "February";
            else if (monthN == 3)
                monthName = "March";
            else if (monthN == 4)
                monthName = "April";
            else if (monthN == 5)
                monthName = "May";
            else if (monthN == 6)
                monthName = "June";
            else if (monthN == 7)
                monthName = "July";
            else if (monthN == 8)
                monthName = "August";
            else if (monthN == 9)
                monthName = "September";
            else if (monthN == 10)
                monthName = "Octorber";
            else if (monthN == 11)
                monthName = "November";
            else if (monthN == 12)
                monthName = "December";
            else
                monthName = "Not found";

            billMonthCombo.Text = monthName;
            billYearCombo.Text = DateTime.Now.Year.ToString();
            billDayCombo.Text = DateTime.Now.Day.ToString();

        }

        private void billSetDateBtn_Click(object sender, EventArgs e)
        {
            setDate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelT.Text = DateTime.Now.ToLongTimeString();
            labelD.Text = DateTime.Now.ToLongDateString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labelT_Click(object sender, EventArgs e)
        {

        }
    }
}
