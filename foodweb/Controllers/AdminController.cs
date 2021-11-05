using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using foodweb.Models;

namespace foodweb.Controllers
{
    public class AdminController : Controller
    {
        foodreceipeEntities db = new foodreceipeEntities();
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Add_menu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_menu(menu m1, HttpPostedFileBase imgupload)
        {
            imgupload.SaveAs(Server.MapPath("~/images/" + imgupload.FileName));
            m1.img = imgupload.FileName;
            db.menus.Add(m1);
            db.SaveChanges();
            return View();
        }

     
    }
}