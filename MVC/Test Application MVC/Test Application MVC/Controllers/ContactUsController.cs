using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_Application_MVC.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}