using MVCViewModel.Models;
using MVCViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCViewModel.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Show()
        {
            Employee e = GetEmployeeInformation();
            User CurrentUser = GetCurrentUser();
            EmployeeVM oEmpVM = new EmployeeVM(e, CurrentUser);
            return View(oEmpVM);
        }

        private User GetCurrentUser()
        {
            User oUser = new User()
            {
                UserName = "Admin"
            };
            return oUser;
        }

        private Employee GetEmployeeInformation()
        {
            Employee oEmployee = new Employee()
            {
                EmoloyeeName = "Tanvir",
                Address = "Dhaka",
                DateOfbirth = new DateTime(1994, 03, 28),
                Salary = 30000
            };
            return oEmployee;
        }

    }
}