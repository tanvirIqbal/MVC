using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCValidation.Models
{
    public class CustomerBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase obj = controllerContext.HttpContext;
            string customerCode = obj.Request.Form["txtCustomerCode"];
            string customerName = obj.Request.Form["txtCustomerName"];
            Customer oCustomer = new Customer();
            oCustomer.CustomerCode = customerCode;
            oCustomer.CustomerName = customerName;

            return oCustomer;
        }
    }
}