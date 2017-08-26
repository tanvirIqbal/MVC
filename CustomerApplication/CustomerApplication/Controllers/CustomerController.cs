using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace Controllers
{
    public class CustomerController : Controller
    {
        CustomerVM _oCustomerVM = null;
        // GET: Customer
        public ActionResult Enter()
        {
            _oCustomerVM = new CustomerVM();
            RefreshCustomerTable();
            return View("EnterCustomer", _oCustomerVM);
        }

        public ActionResult Submit([ModelBinder(typeof(CustomerBinder))] Customer oCustomer)
        {
            _oCustomerVM = new CustomerVM();
            if (ModelState.IsValid)
            {
                CustomerDAL oCustomerDAL = new CustomerDAL();
                oCustomerDAL.Customers.Add(oCustomer);
                oCustomerDAL.SaveChanges();
                _oCustomerVM.customer = new Customer();
            }
            else
            {
                _oCustomerVM.customer = oCustomer;
            }
            RefreshCustomerTable();
            return View("EnterCustomer", _oCustomerVM);
        }

        public ActionResult Search([ModelBinder(typeof(CustomerBinder))] Customer oCustomer)
        {
            _oCustomerVM = new CustomerVM();
            CustomerDAL oCustomerDAL = new CustomerDAL();
            _oCustomerVM.customers = (from x in oCustomerDAL.Customers
                                      where x.CustomerName == oCustomer.CustomerName
                                      select x).ToList<Customer>();
            return View("SearchCustomer", _oCustomerVM);
        }

        public ActionResult EnterSearch()
        {
            _oCustomerVM = new CustomerVM();
            _oCustomerVM.customers = new List<Customer>();
            return View("SearchCustomer", _oCustomerVM);
        }

        private void RefreshCustomerTable()
        {
            CustomerDAL oCustomerDAL = new CustomerDAL();
            _oCustomerVM.customers = oCustomerDAL.Customers.ToList<Customer>();
        }
    }
}