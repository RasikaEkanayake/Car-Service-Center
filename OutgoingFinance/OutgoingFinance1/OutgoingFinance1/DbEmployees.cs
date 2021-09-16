using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OutgoingFinance1
{
    class DbEmployees
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port3306;username=root;password=;database=student";
            MySqlConnection con = new MySqlConnection();
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
        public static void AddEmployees(Employees std)
        {
            string sql = "INSERT INTO student_table"
        }
    }
}
