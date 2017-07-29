using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataPassing.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["MySessionData"] = "This is from Session Data";
            TempData["MyTempData"] = "This is from TempData";
            return RedirectToAction("GoHome", "Home");
        }

        public ActionResult GoHome()
        {
            ViewData["MyTime"] = DateTime.Now.ToString("dd MMM yyyy");
            ViewBag.message = "This is from viewBag";

            List<string> students = new List<string>();
            students.Add("Tanvir");
            students.Add("Fahim");
            students.Add("Jamil");
            students.Add("Noman");
            students.Add("Arka");
            ViewData["Students"] = students;
            return View("MyHomePage");
        }
    }
}