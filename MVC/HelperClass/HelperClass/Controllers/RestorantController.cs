using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperClass.Models;

namespace HelperClass.Controllers
{
    public class RestorantController : Controller
    {
        // GET: Restorant
        public ActionResult ResorantInfo()
        {
            var data = getResorantInfo();
            return View(data);
        }
        
        public string FoodId(int id)
        {
            string profile = " ";
            if (id == 1)
            {
                profile = "FoodId=1";
            }
            else if (id == 2)
            {
                profile = "FoodId =2";
            }
            else
            {
                profile = "no record found";
            }
            return profile;
        }
        public string emloyee(string location, string Food)
        {
            return "loc= " + location + "Food= " + Food;
        }

        private ResorantInfo getResorantInfo()
        {
            return new ResorantInfo()
            {
                Id = 1, Adress = "porbandar", Name = "DilDurbar"
            };
        }
    }
}
 