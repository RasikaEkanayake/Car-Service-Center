using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBillManagement
{
    class IncomeFinanceDB
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=mydb";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("MySQL connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddIncome(IncomeFinance incm)
        {
            string sql = "insert into mytable values (NULL, @incomeCID, @incomeCName, @incomeVID, @incomeTime, @incomeDay, @incomeMonth, @incomeYear, @incomePMethod, @incomePrice)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@incomeCID", MySqlDbType.VarChar).Value = incm.CID;
            cmd.Parameters.Add("@incomeCName", MySqlDbType.VarChar).Value = incm.CName;
            cmd.Parameters.Add("@incomeVID", MySqlDbType.VarChar).Value = incm.VID;
            cmd.Parameters.Add("@incomeTime", MySqlDbType.VarChar).Value = incm.Time;
            cmd.Parameters.Add("@incomeDay", MySqlDbType.Int32).Value = incm.Day;
            cmd.Parameters.Add("@incomeMonth", MySqlDbType.VarChar).Value = incm.Month;
            cmd.Parameters.Add("@incomeYear", MySqlDbType.Int32).Value = incm.Year;
            cmd.Parameters.Add("@incomePMethod", MySqlDbType.VarChar).Value = incm.PMethod;
            cmd.Parameters.Add("@incomePrice", MySqlDbType.Double).Value = incm.Price;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Insertion faild! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        public static void UpdateIncome(IncomeFinance incm, string id)
        {
            string sql = "update mytable set CID = @incomeCID, CName = @incomeCName, VID = @incomeVID, Time = @incomeTime, Day = @incomeDay, Month = @incomeMonth, Year = @incomeYear, PMethod = @incomePMethod, Price = @incomePrice where ID = @incomeID)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@incomeID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@incomeCID", MySqlDbType.VarChar).Value = incm.CID;
            cmd.Parameters.Add("@incomeCName", MySqlDbType.VarChar).Value = incm.CName;
            cmd.Parameters.Add("@incomeVID", MySqlDbType.VarChar).Value = incm.VID;
            cmd.Parameters.Add("@incomeTime", MySqlDbType.VarChar).Value = incm.Time;
            cmd.Parameters.Add("@incomeDay", MySqlDbType.Int32).Value = incm.Day;
            cmd.Parameters.Add("@incomeMonth", MySqlDbType.VarChar).Value = incm.Month;
            cmd.Parameters.Add("@incomeYear", MySqlDbType.Int32).Value = incm.Year;
            cmd.Parameters.Add("@incomePMethod", MySqlDbType.VarChar).Value = incm.PMethod;
            cmd.Parameters.Add("@incomePrice", MySqlDbType.Double).Value = incm.Price;
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Updation faild! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();
        }

        public static void DeleteIncome(string id)
        {
            string sql = "delete from mytable where ID = @incomeID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@incomeID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Deletion faild! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DisplayIncome(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            adp.Fill(dtbl);
            con.Close();
        }
    }
}
