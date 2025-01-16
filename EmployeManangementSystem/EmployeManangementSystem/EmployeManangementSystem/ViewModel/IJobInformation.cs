using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeManangementSystem.ViewModel
{
    internal interface IJobInformation
    {
        void GetEmploye();
        void GetAllEmploye();
        void AddEmployee();
        void DeleteEmployee();
        void UpdateEmployee();
    }
}
