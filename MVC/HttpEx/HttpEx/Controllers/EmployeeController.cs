using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HttpEx.Models;

namespace HttpEx.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult Employee(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Employeepostcreate(employee employee)
        {
            return View();
        }
        [HttpPut]
        public ActionResult Employeeputupdate(int id,employee employee)
        {
            return View();
        }
        [HttpDelete]
        public ActionResult Employeedelete(int id, employee employee)
        {
            return View();
        }
    }
}