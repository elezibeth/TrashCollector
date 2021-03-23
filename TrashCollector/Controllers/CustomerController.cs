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
using Microsoft.AspNetCore.Authorization;

namespace TrashCollector.Controllers
{
    [Authorize(Roles = "Customer")]
    [Authorize(Roles = "Admin")]

    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
           
            return View("Create");
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
              
                var zipInt = Convert.ToInt32(collection["ZipCode"]);
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                Customer cust = new Customer
                {
                    FirstName = collection["FirstName"],
                    LastName = collection["LastName"],
                    AmountOwed = 0,
                    StreetName = collection["StreetName"],
                    City = collection["City"],
                    State = collection["State"],
                    ZipCode = zipInt,
                    Day = collection["Day"]
                    
            };
            _context.Customers.Add(cust);
            _context.SaveChanges();
                var custId = _context.Customer.Where(x => x.LastName == collection["LastName"]).Select(y => y.Id);
            
                return View("Details", custId);
            }
            catch
            {
                return View("Index");
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
