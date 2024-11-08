using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceWeb.Models;
namespace ECommerceWeb.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Shri",LastName = "Patil",Email="shri@gmail.com",Contact="9527595801" });
            customers.Add(new Customer { Id = 2, FirstName = "Raju", LastName = "Jadhav", Email = "raju@gmail.com", Contact = "9527595821" });
            return View(customers);
        }
    }
}