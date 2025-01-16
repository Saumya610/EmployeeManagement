using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeManangementSystem.Model
{
    internal class JobInformation
    {
        private string Role { get; set; }
        private string department { get; set; }
        private DateTime joiningDate { get; set; }
        private double salary { get; set; }
        private string managerName { get; set; }

        public JobInformation(string role, string dept, DateTime date, double sal, string mname)
        {
            this.Role = role;
            this.department = dept;
            this.joiningDate = date;
            this.salary = sal;
            this.managerName = mname;
        }
    }
}
