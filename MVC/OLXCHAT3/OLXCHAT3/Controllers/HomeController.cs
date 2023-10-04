using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OLXCHAT3.Models;
using chatdb;
using System.Data.SqlClient;
using System.Configuration;

namespace OLXCHAT3.Controllers
{
    
    public class HomeController : Controller
    {
        DBContext dbb = null;
        // GET: Home
        public ActionResult Index()
        {
            dbb = new DBContext();
            return View();
        }

        //public ActionResult Index(ChatMddual chat)
        //{
        //    if(ModelState.IsValid==true)
        //    {
        //        DBContext db = new DBContext();
        //        db.insertChat(chat);
        //        return View();
        //    }

        //    return View();
        //}

        public ActionResult select()
        {
            DBContext db = new DBContext();
            List<ChatMddual> obj = db.GetChatMdduals();
            return View(obj);

            //DBContext dbuser = new DBContext();
            //List<users> objuser = db.GetUsersmodual();
            //return View(objuser);
        }
        [HttpPost]
        public ActionResult select(ChatMddual chat)
        {
            if (ModelState.IsValid == true)
            {
                DBContext db = new DBContext();
                bool chack = db.insertChatViaSend(chat);
                if (chack == true)
                {
                    TempData["InsertMsg"] = "Data Inserted";
                    ModelState.Clear();
                    return RedirectToAction("select", "Home");
                }
            }
            return View(chat);
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(ChatMddual chat)
        {
            if (ModelState.IsValid == true)
            {
                DBContext db = new DBContext();
                bool chack = db.insertChat(chat);
                if (chack == true)
                {
                    TempData["InsertMsg"] = "Data Inserted";
                    ModelState.Clear();
                    return RedirectToAction("select", "Home");
                }
            }
            return View(chat);
        }
        //[HttpPost]
        //public ActionResult create(ChatMddual chat)
        //{
        //    if (ModelState.IsValid == true)
        //    {
        //       int id= dbb.inesertchat(chat);
        //        if (id<0)
        //        {
        //            ModelState.Clear();
        //            ViewBag.IsSuccess = "Inserted";
        //        }
        //    }
        //        return View();
        //}
      



    }


   
}