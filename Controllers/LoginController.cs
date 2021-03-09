using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_demo.Models;

namespace mvc_demo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(LoginDetails loginDetails)
        {
            ReleaseManagementContext context = new ReleaseManagementContext();
            LoginDetails user = context.loginDetails
                                .FirstOrDefault(ud => ud.UserName == loginDetails.UserName && ud.Password == loginDetails.Password);

            if(user!= null)
            {
                TempData["username"] = loginDetails.UserName;
                 TempData["role"] = user.Role;
                return RedirectToAction("Index", "Student");
                    }
            return View();
        }

    }
}