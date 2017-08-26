using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class CustomerBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase obj = controllerContext.HttpContext;
            string customerCode = obj.Request.Form["customer.CustomerCode"];
            string customerName = obj.Request.Form["customer.CustomerName"];
            Customer oCustomer = new Customer()
            {
                CustomerCode = customerCode,
                CustomerName = customerName
            };
            return oCustomer;
        }
    }
}