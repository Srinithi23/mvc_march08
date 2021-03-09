using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_demo.Models;

namespace mvc_demo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                    return RedirectToAction("index", customer);
                ModelState.AddModelError("ValidationError", "Some values are not valid");
                return View();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}