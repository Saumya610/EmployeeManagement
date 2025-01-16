using EmployeManangementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeManangementSystem.ViewModel
{
    internal class EmployeModel : IEmployeModel
    {
		IList<Employe> employe;
		
		public EmployeModel()
		{
			employe = new List<Employe>();		
		}
					
        void IEmployeModel.GetEmploye()
        {
			Console.WriteLine("Enter id");
			int id = int.Parse(Console.ReadLine());
            bool employFound =false;
            
            foreach (Employe emp in employe)
            {
                if (emp.GetId() == id)
                {
                    Console.WriteLine(emp);
                    employFound = true;
                    return;
                }               
			}
            
            if (!employFound)
            {
                Console.WriteLine("Employe not found");
            }
        }

        void IEmployeModel.GetAllEmploye()
        {
            foreach (Employe emp in employe)
            {           
                Console.WriteLine(emp);              
            }
        }

        void IEmployeModel.AddEmployee()
        {
            Console.WriteLine("Enter ID to add employee");
            int id = int.Parse(Console.ReadLine());
            bool employFound = false;
            foreach (Employe emp1 in employe)
            {
                if (emp1.GetId() == id)
                {
                    Console.WriteLine("Employee already exists!!");
                    employFound = true;
                    return;
                }
            }

            if (!employFound)
            {
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter ContactNo");
                double Contact = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Department");
                string department = Console.ReadLine();

                Employe emp = new Employe(id, name, Contact, department);
                employe.Add(emp);
                Console.WriteLine("Employee Added");
            }

           
        }
        void IEmployeModel.DeleteEmployee()
        {
            Console.WriteLine("Enter ID");
            int id = int.Parse(Console.ReadLine());
            bool employFound = false;
            foreach (Employe emp in employe)
            {
                if (emp.GetId() == id)
                {
                   employFound = true;
                   employe.Remove(emp);
                   Console.WriteLine("Employe Deleted");
                   return;
                }
            }

            if (!employFound)
            {
                Console.WriteLine("Employe not found");
            }

        }
        void IEmployeModel.UpdateEmployee()
        {
            Console.WriteLine("Enter ID");
            int id = int.Parse(Console.ReadLine());
            bool employFound = false;
            foreach (Employe emp in employe)
            {
                if (emp.GetId() == id)
                {
                    employFound = true;
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter ContactNo");
                    double Contact = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Department");
                    string department = Console.ReadLine();
                    emp.SetName(name);
                    emp.SetContactNo(Contact);
                    emp.SetDepartment(department);
                    Console.WriteLine("Employee Update" + " " +emp);
                }
            }

            if (!employFound)
            {
                Console.WriteLine("Employe not found");
            }

        }
    }
}