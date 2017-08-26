using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel
{
    public class CustomerVM
    {
        public Customer customer { get; set; }
        public List<Customer> customers { get; set; }
    }
}