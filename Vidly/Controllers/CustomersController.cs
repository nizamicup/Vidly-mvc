using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
            {
                new Customer{Name= "John Smith"},
                new Customer{Name= "Mary Williams"}
            };
        // GET: Customers
        public ActionResult Index()
        {
            
            return View(customers);
        }

        public ActionResult Detail(int id)
        {
            var customer = customers[id];
            return View(customer);
        }
    }
}