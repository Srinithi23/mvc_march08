using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_demo.Models;

namespace mvc_demo.Controllers
{
    public class LoginUserController : Controller
    {
        // GET: LoginUser
        ReleaseManagementContext db = new ReleaseManagementContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(LoginDetails loginDetails)
        {
            try
            {
                db.loginDetails.Add(loginDetails);
                db.SaveChanges();
                ViewBag.Message = "User created";
            }
            catch (Exception ex)
            {
                ViewBag.Message=ex.Message;
            }
            return View();
        }

    }
}