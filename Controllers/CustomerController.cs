using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rozdzial3_C.Models;

namespace Rozdzial3_C.Controllers
{
    public class CustomerController : Controller
    {
        private readonly EFCDbContext Context;

        public CustomerController(EFCDbContext context)
        {
            this.Context = context;
        }

        public IActionResult Index()
        {
            var customers = Context.Customers.Include(x => x.Address).ToList();
            //var customers = Context.Customers.ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CustomerModel customer)
        {
            customer.DateAdded = DateTime.Now;

            if (ModelState.IsValid)
            {
                Context.Customers.Add(customer);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        public IActionResult Detail(int id)
        {
            var customer = Context.Customers.Include(x => x.Address).Single(x => x.ID == id);
            return View(customer);
        }
    }
}