using MVCModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModel.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Enter()
        {
            return View("EnterProduct");
        }
        public ActionResult Submit(Product oProduct)
        {
            // This Product object will be automaticly filled
            // because name of the Product object properties are matched with 
            // the name of the input fields.
            return View("Product", oProduct);
        }
    }
}