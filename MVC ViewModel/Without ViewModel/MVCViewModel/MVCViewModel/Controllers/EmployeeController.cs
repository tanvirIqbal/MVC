using MVCViewModel.Models;
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
            ViewBag.CurrentUser = GetCurrentUser();
            ViewData["cUser"] = GetCurrentUser();
            return View(e);
        }

        private User GetCurrentUser()
        {
            User oUser = new User();
            oUser.UserName = "Admin";
            return oUser;
        }

        private Employee GetEmployeeInformation()
        {
            Employee oEmployee = new Employee();
            oEmployee.EmoloyeeName = "Tanvir";
            oEmployee.Address = "Dhaka";
            oEmployee.DateOfbirth = new DateTime(1994, 03, 28);
            oEmployee.Salary = 10000;
            return oEmployee;
        }

    }
}