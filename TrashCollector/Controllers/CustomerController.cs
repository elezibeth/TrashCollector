using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrashCollector.Data;
using TrashCollector.Models;
using TrashCollector;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TrashCollector.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CustomerController
        public IActionResult Index()
        {
            return View();
        }

        //configure customer settings
        public IActionResult NewCustomerConfigure()
        {
            return View();
        }
        public IActionResult SelectGarbageDay()
        {
            
            
            var list1 = new List<DayOfWeek>();
            list1.Add(DayOfWeek.Monday);
            list1.Add(DayOfWeek.Wednesday);
            list1.Add(DayOfWeek.Friday);
            var Days = new SelectList(list1, "Name", "Name");



            return View("SelectGarbageDay", Days);
        }

        // GET: CustomerController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewCustomerConfigure(IFormCollection collection)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var cust = new Customer
            {
                FirstName = collection["FirstName"],
                LastName = collection["LastName"],

            };
            _context.Customers.Add(cust);
            _context.SaveChanges();
            return View("SelectGarbageDay");
        }
        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var cust = new Customer
                {
                    FirstName = collection["FirstName"],
                    LastName = collection["LastName"],
                    
                };
                _context.Customers.Add(cust);
                _context.SaveChanges();
                return View();
                
            }
            catch
            {
                return View();
            }
        }

      

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
       
    }
}
