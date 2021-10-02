using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Booking
{
    public partial class BookingReport : Form
    {
        public BookingReport()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //itplogo
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("itplogo.png");
                        PNG.ScalePercent(5f);
                        PNG.Alignment = 1;
                        doc.Add(PNG);

                        Paragraph para1 = new Paragraph("ROYAL CAR SERVICE CENTER", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 30f));
                        Paragraph para21 = new Paragraph("Sri Jayawardhanapura", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f));
                        Paragraph para22 = new Paragraph("Kotte", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f));
                        Paragraph para2 = new Paragraph("Booking Management");
                        Paragraph para3 = new Paragraph("Monthly Report\n\n\n\n\n\n\n\n\n\n\n\n\n");
                        para1.Alignment = 1;
                        para2.Alignment = 1;
                        para21.Alignment = 1;
                        para22.Alignment = 1;
                        para3.Alignment = 1;
                        doc.Add(para1);
                        doc.Add(para21);
                        doc.Add(para22);
                        doc.Add(para2);
                        doc.Add(para3);

                        PdfPTable table = new PdfPTable(4);

                        PdfPCell cell = new PdfPCell(new Phrase("Daily Booking Count", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20f)));
                        cell.Colspan = 4;
                        cell.HorizontalAlignment = 1;
                        table.AddCell(cell);

                        table.AddCell("Day 1 ");
                        table.AddCell(bktxt01.Text);
                        table.AddCell("Day 2 ");
                        table.AddCell(bktxt02.Text);

                        table.AddCell("Day 3 ");
                        table.AddCell(bktxt03.Text);
                        table.AddCell("Day 4 ");
                        table.AddCell(bktxt04.Text);

                        table.AddCell("Day 5 ");
                        table.AddCell(bktxt05.Text);
                        table.AddCell("Day 6 ");
                        table.AddCell(bktxt06.Text);

                        table.AddCell("Day 7 ");
                        table.AddCell(bktxt07.Text);
                        table.AddCell("Day 8 ");
                        table.AddCell(bktxt08.Text);

                        table.AddCell("Day 9 ");
                        table.AddCell(bktxt09.Text);
                        table.AddCell("Day 10 ");
                        table.AddCell(bktxt10.Text);

                        table.AddCell("Day 11 ");
                        table.AddCell(bktxt11.Text);
                        table.AddCell("Day 12 ");
                        table.AddCell(bktxt12.Text);

                        table.AddCell("Day 13 ");
                        table.AddCell(bktxt13.Text);
                        table.AddCell("Day 14 ");
                        table.AddCell(bktxt14.Text);

                        table.AddCell("Day 15 ");
                        table.AddCell(bktxt15.Text);
                        table.AddCell("Day 16 ");
                        table.AddCell(bktxt16.Text);

                        table.AddCell("Day 17 ");
                        table.AddCell(bktxt17.Text);
                        table.AddCell("Day 18 ");
                        table.AddCell(bktxt18.Text);

                        table.AddCell("Day 19 ");
                        table.AddCell(bktxt19.Text);
                        table.AddCell("Day 20 ");
                        table.AddCell(bktxt20.Text);

                        table.AddCell("Day 21 ");
                        table.AddCell(bktxt21.Text);
                        table.AddCell("Day 22 ");
                        table.AddCell(bktxt22.Text);

                        table.AddCell("Day 23 ");
                        table.AddCell(bktxt23.Text);
                        table.AddCell("Day 24 ");
                        table.AddCell(bktxt24.Text);

                        table.AddCell("Day 25 ");
                        table.AddCell(bktxt25.Text);
                        table.AddCell("Day 26 ");
                        table.AddCell(bktxt26.Text);

                        table.AddCell("Day 27 ");
                        table.AddCell(bktxt27.Text);
                        table.AddCell("Day 28 ");
                        table.AddCell(bktxt28.Text);

                        table.AddCell("Day 29 ");
                        table.AddCell(bktxt29.Text);
                        table.AddCell("Day 30 ");
                        table.AddCell(bktxt30.Text);

                        table.AddCell("Day 31 ");
                        table.AddCell(bktxt31.Text);
                        table.AddCell("       ");
                        table.AddCell("    ");

                        doc.Add(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void BookingReport_Load(object sender, EventArgs e)
        {
            
        }

        public void loadCalenderView(String month)
        {
            bktxt01.Text = Convert.ToString(bookingtb.getBookingCountForMonth("1", month));
            bktxt02.Text = Convert.ToString(bookingtb.getBookingCountForMonth("2", month));
            bktxt03.Text = Convert.ToString(bookingtb.getBookingCountForMonth("3", month));
            bktxt04.Text = Convert.ToString(bookingtb.getBookingCountForMonth("4", month));
            bktxt05.Text = Convert.ToString(bookingtb.getBookingCountForMonth("5", month));
            bktxt06.Text = Convert.ToString(bookingtb.getBookingCountForMonth("6", month));
            bktxt07.Text = Convert.ToString(bookingtb.getBookingCountForMonth("7", month));
            bktxt08.Text = Convert.ToString(bookingtb.getBookingCountForMonth("8", month));
            bktxt09.Text = Convert.ToString(bookingtb.getBookingCountForMonth("9", month));
            bktxt10.Text = Convert.ToString(bookingtb.getBookingCountForMonth("10", month));
            bktxt11.Text = Convert.ToString(bookingtb.getBookingCountForMonth("11", month));
            bktxt12.Text = Convert.ToString(bookingtb.getBookingCountForMonth("12", month));
            bktxt13.Text = Convert.ToString(bookingtb.getBookingCountForMonth("13", month));
            bktxt14.Text = Convert.ToString(bookingtb.getBookingCountForMonth("14", month));
            bktxt15.Text = Convert.ToString(bookingtb.getBookingCountForMonth("15", month));
            bktxt16.Text = Convert.ToString(bookingtb.getBookingCountForMonth("16", month));
            bktxt17.Text = Convert.ToString(bookingtb.getBookingCountForMonth("17", month));
            bktxt18.Text = Convert.ToString(bookingtb.getBookingCountForMonth("18", month));
            bktxt19.Text = Convert.ToString(bookingtb.getBookingCountForMonth("19", month));
            bktxt20.Text = Convert.ToString(bookingtb.getBookingCountForMonth("20", month));
            bktxt21.Text = Convert.ToString(bookingtb.getBookingCountForMonth("21", month));
            bktxt22.Text = Convert.ToString(bookingtb.getBookingCountForMonth("22", month));
            bktxt23.Text = Convert.ToString(bookingtb.getBookingCountForMonth("23", month));
            bktxt24.Text = Convert.ToString(bookingtb.getBookingCountForMonth("24", month));
            bktxt25.Text = Convert.ToString(bookingtb.getBookingCountForMonth("25", month));
            bktxt26.Text = Convert.ToString(bookingtb.getBookingCountForMonth("26", month));
            bktxt27.Text = Convert.ToString(bookingtb.getBookingCountForMonth("27", month));
            bktxt28.Text = Convert.ToString(bookingtb.getBookingCountForMonth("28", month));
            bktxt29.Text = Convert.ToString(bookingtb.getBookingCountForMonth("29", month));
            bktxt30.Text = Convert.ToString(bookingtb.getBookingCountForMonth("30", month));
            bktxt31.Text = Convert.ToString(bookingtb.getBookingCountForMonth("31", month));
        }

        

        private void loadCalenderViewBtn1_Click(object sender, EventArgs e)
        {
            if (calenderMonthCombo.Text == string.Empty)
            {
                MessageBox.Show("Select a month");
                return;
            }
            loadCalenderView(calenderMonthCombo.Text);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt01_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt02_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt03_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt04_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt05_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt06_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt07_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt08_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt09_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt10_Click(object sender, EventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt12_Click(object sender, EventArgs e)
        {

        }

        private void bktxt13_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt14_Click(object sender, EventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt15_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void bktxt18_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt19_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt20_Click(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void bktxt21_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void bktxt22_Click(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void bktxt11_Click(object sender, EventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bktxt16_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void bktxt17_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
