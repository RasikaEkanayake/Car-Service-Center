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
    public partial class AddNewIncome : Form
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

        public AddNewIncome()
        {
            InitializeComponent();
        }

        private void AddNewIncome_Load(object sender, EventArgs e)
        {
            addNewCusIDtxt.Text = Bill.setCusID;
            addNewCusNametxt.Text = Bill.setCusName;
            addNewVehIDtxt.Text = Bill.setVehicleID;
            addNewDaytxt.Text = Bill.setDayForm;
            addNewMonthtxt.Text = Bill.setMonthForm;
            addNewYeartxt.Text = Bill.setYearForm;
            addNewPayMtxt.Text = Bill.setPaymentMethod;
            addNewPricetxt.Text = Bill.setPrice;

            addNewSaveBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addNewSaveBtn.Width, addNewSaveBtn.Height, 5, 5));
            addNewResetBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addNewResetBtn.Width, addNewResetBtn.Height, 5, 5));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addNewDaytxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void addNewMonthtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNewYeartxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
