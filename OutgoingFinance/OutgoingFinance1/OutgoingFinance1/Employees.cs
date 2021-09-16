using System;
using System.Collections.Generic;
using System.Text;

namespace OutgoingFinance1
{
    class Employees
    {
        public string emp_name { get; set; }
        public string emp_id { get; set; }
        public string email { get; set; }
        public string ot { get; set; }
        public string phone { get; set; }
        public string basic { get; set; }
        public string attendence { get; set; }
        public string calculatedsalary { get; set; }

        public Employees(string emp_name, string emp_id, string email, string ot, string phone, string basic, string attendence, string calculatedsalary)
        {
            this.emp_name = emp_name;
            this.emp_id = emp_id;
            this.email = email;
            this.ot = ot;
            this.phone = phone;
            this.basic = basic;
            this.attendence = attendence;
            this.calculatedsalary = calculatedsalary;
        }
    }
}
