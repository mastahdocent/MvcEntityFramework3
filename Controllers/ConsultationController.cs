using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rozdzial3_C.Models;

namespace Rozdzial3_C.Controllers
{
    public class ConsultationController : Controller
    {
        private readonly EFCDbContext Context;

        public ConsultationController(EFCDbContext context)
        {
            this.Context = context;
        }

        public IActionResult Index(int id)
        {
            var customer = Context.Customers.Include(x => x.Consultations).Single(x => x.ID == id);
            return View(customer);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(int id, [FromForm] ConsultationModel consult)
        {
            consult.CustomerID = id;
            if (ModelState.IsValid)
            {
                Context.Add<ConsultationModel>(consult);
                Context.SaveChanges();
                return RedirectToAction("Index", new { id });
            }

            return View(consult);
        }
    }
}