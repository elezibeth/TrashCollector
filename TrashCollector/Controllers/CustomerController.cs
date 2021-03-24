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
        public IActionResult Random()
        {
            var rand = _context.Customers;
            return View(rand);
        }
        public IActionResult GetBill(int id)
        {
            var bill = _context.Customer.Where(i => i.Id == id).FirstOrDefault();
            return View(bill);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetBill()
        {
            return View();
        }

        public IActionResult ChangePickupDay(int id)
        {
            var pickup = _context.Customer.Where(i => i.Id == id).FirstOrDefault();
            return View(pickup);
        }
        // GET: CustomerController/Details/5
        public IActionResult ConfirmDetails()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDetails(IFormCollection collection)
        {
            var custId = _context.Customers.Select(z => z.Id).FirstOrDefault();
            try
            {
                var cust = _context.Customers.Where(f => f.FirstName == collection["FirstName"])
                    .Where(l => l.LastName == collection["LastName"])
                    .FirstOrDefault();
                cust.Day = collection["Day"];
                _context.SaveChanges();
                custId = cust.Id;
                return RedirectToAction("Details", custId);
            }
            catch
            {
                return View("Index");
            }
        }


        public ActionResult Details(int custId)
        {
            var cust = _context.Customer.Where(c => c.Id == custId).Select(d => d).FirstOrDefault();
            return View(cust);
        }
        [HttpPost]
        public IActionResult Details()
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
        public IActionResult ChangePickupDay(IFormCollection collection)
        {
            var custId = _context.Customers.Select(z => z.Id).FirstOrDefault();
            try
            {
                var cust = _context.Customers.Where(f => f.FirstName == collection["FirstName"])
                    .Where(l => l.LastName == collection["LastName"])
                    .FirstOrDefault();
                cust.Day = collection["Day"];
                _context.SaveChanges();
                return View("Index");
            }
            catch
            {
                return View("Index");
            }
        }


      
        [HttpPost]
        
        public IActionResult PauseService(IFormCollection collection)
        {
            
            var zip = Convert.ToInt32(collection["CustomerZip"]);
            var lastname = collection["LastName"];
            var lastnamest = Convert.ToString(collection["CustomerLastName"]);
            var firstNameSt = Convert.ToString(collection["CustomerFirstName"]);
            var customer = _context.Customers.Where(i => i.FirstName == firstNameSt).Select(c => c).FirstOrDefault();

            var startDate = Convert.ToDateTime(collection["StartDate"]);
            var endDate = Convert.ToDateTime(collection["EndDate"]);
            PauseServicesFour pause2 = new PauseServicesFour()
            {
                StartDate = startDate,
                EndDate = endDate,
                CustomerZip = zip,
                CustomerFirstName = collection["CustomerFirstName"],
                CustomerLastName = collection["CustomerLastName"],
                CustomerId = customer.Id

            };
            _context.PauseServicesFours.Add(pause2);
            _context.SaveChanges();


            return View("Index");
         

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
