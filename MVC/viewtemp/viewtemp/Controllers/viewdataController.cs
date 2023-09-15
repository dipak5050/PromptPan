using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viewtemp.Models;

namespace viewtemp.Controllers
{
    public class viewdataController : Controller
    {
        // GET: viewdata
        public ActionResult Index()
        {
            //ViewData["key"] = "THis is View data";
            ViewBag.username = new List<string>() { "one", "two", "three" };
            //TempData["data"] = "hello there from temp";
            //shareTempData sharedTemp = new shareTempData();
            //sharedTemp.data = Convert.ToString(TempData["data"]);
            //// sharedTemp.data =Convert.ToString(TempData.Peek("data"));
            //ViewData["key"] = "hello there";
            List<Id> nm = new List<Id>()
            {
                new Id(){name="dipu"},
                new Id() {name="jayesh"},
                new Id(){name="ekbal" }
                
            };
            ViewBag.mylst = nm;
            ViewData["key"] = nm;
            return View(); 
        }
        
    }
   
        //public class shareTempData
        //{
        //    public string data { get; set; }
        //}
}