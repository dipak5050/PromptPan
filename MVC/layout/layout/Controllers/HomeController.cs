using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace layout.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route ("getname")]
        public ActionResult GetName()
        {
            return View();
        }
        [Route ("Addname")]
        public ActionResult AddName()
        {
            return View();
        }

    }
}