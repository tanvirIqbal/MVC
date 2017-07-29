using MVCModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModel.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer oCustomer = new Customer { CustomerCode = "1001", CustomerName = "Fahim" };
            return View("Customer",oCustomer);
        }

        public ActionResult Enter()
        {
            return View("EnterCustomer");
        }

        public ActionResult Submit()
        {
            Customer oCustomer = new Customer();
            oCustomer.CustomerCode = Request.Form["CustomerCode"];
            oCustomer.CustomerName = Request.Form["CustomerName"];
            return View("Customer", oCustomer);
        }
    }
}