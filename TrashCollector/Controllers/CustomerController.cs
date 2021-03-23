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
    //[Authorize(Roles = "Customer")]

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
            var customerMod = _context.Customers;
            return View(customerMod);
        }
        public IActionResult PauseService()
        {

            return View();

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PauseService(IFormCollection collection)
        {
            
            var zip = Convert.ToInt32(collection["CustomerZip"]);
            var custId = _context.Customers.Select(z => z.Id).FirstOrDefault();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var startDate = Convert.ToDateTime(collection["StartDate"]);
            var endDate = Convert.ToDateTime(collection["EndDate"]);

            try
            {
                PauseServiceRequest pause = new PauseServiceRequest
                {
                    StartDate = startDate,
                    EndDate = endDate,
                    CustomerZip = zip,
                    CustomerId = custId


                };
                _context.PauseServiceRequests.Add(pause);
                _context.SaveChanges();
                return View("Index");
            }
            catch
            {
                return View("Index");
            }

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
            
                return View("Index");
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
