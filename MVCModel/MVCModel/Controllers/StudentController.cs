using MVCModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModel.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Enter()
        {
            return View("EnterStudent");
        }
        public ActionResult Submit([ModelBinder(typeof(StudentBinder))] Student oStudent)
        {
            // If name of the Input field doesn't match with the name of the Student Property
            // we create StudentBinder class. 
            return View("Student", oStudent);
        }
    }
}