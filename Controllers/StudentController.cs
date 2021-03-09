using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_demo.Models;

namespace mvc_demo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public string Index()
        {
            string userData = TempData.Peek("username").ToString() + " " + TempData.Peek("role").ToString();
            return userData;
        }
        [HttpGet]
        public ActionResult AnotherPage()
        {
            //view data is a dictionary
            //step 1

            ViewData["StudentName"] = "Ramu";
            int[] nums = { 1, 2, 34, 53, 5, 42 };

            //below snippet is for viewdata
            // ViewData["numbers"] = nums;


            //  below snippet is for viewbag
            ViewBag.numbers = nums;

            return View();
        }

        public ActionResult StudentDetails()
        {
            Student student = new Student(101, "Ramu", 23);
            return View(student);
        }

        public ActionResult SelectCity()
        {
            /*List<SelectListItem> mycities = new List<SelectListItem>();
            mycities.Add(new SelectListItem() { Text = "Agra", Value = "AgraCity" });
            mycities.Add(new SelectListItem() { Text = "Chennai", Value = "ChennaiCity" });
            mycities.Add(new SelectListItem() { Text = "Delhi", Value = "DelhiCity" });
            mycities.Add(new SelectListItem() { Text = "Bangalore", Value = "BangaloreCity" });
            return View();*/


            Address address = new Address();
            ViewBag.Cities = address.SelectedCity;
            return View(address);
        }
     
        [HttpPost]

          public string SelectCity(Address address)
          {
            return address.SelectedCity;
          }
    }
}