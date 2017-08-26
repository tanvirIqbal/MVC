using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult GoHome()
        {
            ViewBag.msg = "Welcome to MVC Customer Application.";
            return View("GoHome");
        }
    }
}