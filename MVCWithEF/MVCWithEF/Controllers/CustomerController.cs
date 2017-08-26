﻿using MVCValidation.Models;
using MVCWithEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCValidation.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult EnterCustomer()
        {
            return View(new Customer());
        }

        public ActionResult Submit(Customer oCustomer)
        {
            if (ModelState.IsValid)
            {
                CustomerDAL oCustomerDAL = new CustomerDAL();
                oCustomerDAL.Customers.Add(oCustomer);
                oCustomerDAL.SaveChanges();
                return View("Customer", oCustomer);
            }
            else
            {
                return View("EnterCustomer",oCustomer);
            }
            
        }
    }
}