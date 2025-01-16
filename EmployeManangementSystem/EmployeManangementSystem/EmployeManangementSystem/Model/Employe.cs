using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeManangementSystem.Model
{
    internal class Employe
    {
        private string Name { get; set; }
        private double ContactNo { get; set; }
        private string Department { get; set; }
        private int ID { get; set; }

        public Employe(int id,string name,double contactNo,string department)
        {
            ID = id;
            Name = name;
            ContactNo = contactNo;
            Department = department;
        }

        public override string ToString()
        {
            return this.Name + " " + this.ContactNo + " " + this.ID + " " + this.Department;
        }

        public int GetId()
        {
            return this.ID;
        }

        public void SetDepartment(string department)
        {
            this.Department = department;
        }
        public void SetContactNo(double no)
        {
            this.ContactNo = no;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}
