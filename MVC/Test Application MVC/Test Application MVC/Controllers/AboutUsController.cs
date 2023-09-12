using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_Application_MVC.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: About
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}