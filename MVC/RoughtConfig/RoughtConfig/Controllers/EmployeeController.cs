using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoughtConfig.Models;


namespace RoughtConfig.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Employeeall()
        {
            var emp = employee();
            return View(emp);
        }
        public ActionResult GetEmployee(int id)
        {
            var emp1 = employee().FirstOrDefault(x=>x.id==id);
            return View(emp1);
        }
        public ActionResult Employeeadress(int id)
        {
            var emp2 = employee().Where(x => x.id==id).Select(x => x.adress).FirstOrDefault();
            return View(emp2);
        }
    
    public List<employee> employee()
    {
            return new List<employee>()
            {
                new employee()
                {
                    id = 1,
                    city = "pbr",
                    name = "dipu",

                    adress = new adress()
                    {
                        city = "porbandar",
                        homenum = "00n1n2"
                    }
                },

                new employee()
                {
                    id = 2,
                    city = "Kutiyana",
                    name = "kara",

                    adress = new adress()
                    {
                        city = "kutiyana",
                        homenum = "012n1n3"
                    }
                },

                new employee()
                {
                    id = 3,
                    city = "Ranavav",
                    name = "jayesh",

                    adress = new adress()
                    {
                        city = "junagdh",
                        homenum = "14j4j23"
                    }
                },
          
            };

    }
    
}
}