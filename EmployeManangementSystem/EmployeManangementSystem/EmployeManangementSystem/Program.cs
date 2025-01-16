using System;
using EmployeManangementSystem.ViewModel;
using Microsoft.VisualBasic.FileIO;
namespace EmployeManangementSystem
{
    internal class Program
    {
        public IEmployeModel employeModel;

        public Program()
        {
            employeModel = new EmployeModel();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.StartProgram();
        }

        private void StartProgram()
        {
            int option;
            do
            {
                Console.WriteLine("1.Add Employee 2.Update Employee 3.Remove Employee 4.Employe 5.AllEmploye Details 0.Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        employeModel.AddEmployee();
                        break;
                    case 2:
                        employeModel.UpdateEmployee();
                        break;
                    case 3:
                        employeModel.DeleteEmployee();
                        break;
                    case 4:
                        employeModel.GetEmploye();
                        break;
                    case 5:
                        employeModel.GetAllEmploye();
                        break;
                    default:
                        Console.WriteLine("incorrect input");
                        break;
                }
            } while (option != 0);
        }
    }
}
