using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Booking
{
    class bookingtb
    {

        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=booking;SslMode=none";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql connection \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void Addbooking(booking bk)
        {
            string sql = "INSERT INTO bookingtb VALUES (NULL, @CustomerName, @ContactNumber, @VehicalNumber, @NIC, @BookingType, @Time, @Day, @Month, @ServiceSlot )";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@CustomerName", MySqlDbType.VarChar).Value = bk.C_Name;
            cmd.Parameters.Add("@ContactNumber", MySqlDbType.VarChar).Value = bk.Contact_No;
            cmd.Parameters.Add("@VehicalNumber", MySqlDbType.VarChar).Value = bk.Vehicle_No;
            cmd.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = bk.NIC;
            cmd.Parameters.Add("@BookingType", MySqlDbType.VarChar).Value = bk.B_Type;
            cmd.Parameters.Add("@Time", MySqlDbType.VarChar).Value = bk.Time;
            cmd.Parameters.Add("@Day", MySqlDbType.VarChar).Value = bk.Day;
            cmd.Parameters.Add("@Month", MySqlDbType.VarChar).Value = bk.Month;
            cmd.Parameters.Add("@ServiceSlot", MySqlDbType.VarChar).Value = bk.Service_Slot;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not insert \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
    }

        public static void Updatebooking(booking bk, String id)
        {
            string sql = "UPDATE bookingtb SET C_Name = @CustomerName, Contact_No = @ContactNumber, Vehicle_No = @VehicalNumber, NIC = @NIC, B_Type = @BookingType, Time = @Time, Day = @Day, Month = @Month, Service_Slot = @ServiceSlot WHERE BID = @Bid ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@Bid", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@CustomerName", MySqlDbType.VarChar).Value = bk.C_Name;
            cmd.Parameters.Add("@ContactNumber", MySqlDbType.VarChar).Value = bk.Contact_No;
            cmd.Parameters.Add("@VehicalNumber", MySqlDbType.VarChar).Value = bk.Vehicle_No;
            cmd.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = bk.NIC;
            cmd.Parameters.Add("@BookingType", MySqlDbType.VarChar).Value = bk.B_Type;
            cmd.Parameters.Add("@Time", MySqlDbType.VarChar).Value = bk.Time;
            cmd.Parameters.Add("@Day", MySqlDbType.VarChar).Value = bk.Day;
            cmd.Parameters.Add("@Month", MySqlDbType.VarChar).Value = bk.Month;
            cmd.Parameters.Add("@ServiceSlot", MySqlDbType.VarChar).Value = bk.Service_Slot;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not update \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Deletebooking(string id)
        {
            string sql = "DELETE FROM bookingtb WHERE BID = @BID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@BID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not delete \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static string getServiceSlot(string t)
        {
            try
            {
                
                MySqlConnection con = GetConnection();
                string sqlq = "select Service_Slot from bookingtb where Time like '%" + t + "%'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["Service_Slot"].ToString();
                    return g;
                }

                return "read failed";
            }
            catch (Exception ex)
            {

            }

            return "failed";
        }

        public static int getBookingCountForMonth(String d,String m)
        {
            try
            {
                int x;

                MySqlConnection con = GetConnection();
                string sqlq = "select count(*) as 'count' from bookingtb where Month = '" + m + "' and Day = '" + d + "'";
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sqlq;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string g = dr["count"].ToString();
                    x = Convert.ToInt32(g);
                    return x;
                }

                return 0;
            }
            catch (Exception ex)
            {

            }

            return 0;
        }
    }
    
}
