using MVCViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCViewModel.ViewModel
{
    public class EmployeeVM
    {
        public Employee CurrentEmployee { get; set; }
        public User CurrentUser { get; set; }

        public EmployeeVM(Employee oEmployee, User oUser)
        {
            CurrentEmployee = oEmployee;
            CurrentUser = oUser;
        }
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - CurrentEmployee.DateOfbirth.Year;
                if (CurrentEmployee.DateOfbirth > DateTime.Now.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
        }

        public string SalaryColor
        {
            get
            {
                if (CurrentEmployee.Salary > 20000)
                {
                    return "red";
                }
                else
                {
                    return "green";
                }
            }

        }
    }
}