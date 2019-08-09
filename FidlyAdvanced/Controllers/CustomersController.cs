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

        public static List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Fyrik" },
            new Customer { Id = 2, Name = "Koko" }
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customerList = from customer in customers where customer.Id == id select customer;
            return View(customerList);
        }
    }
}