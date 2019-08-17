using FidlyAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FidlyAdvanced.Controllers
{
    public class CustomersController : Controller
    {
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Fyrik" },
                new Customer { Id = 2, Name = "Koko" }
            };
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            return View(customer);
        }
    }
}