using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_demo.Controllers
{
    public class LayoutExampleController : Controller
    {
        // GET: LayoutExample
        public ActionResult Index()
        {
            return View();
        }
    }
}