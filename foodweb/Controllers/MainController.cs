using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using foodweb.Models;

namespace foodweb.Controllers
{
    public class MainController : Controller
    {
        foodreceipeEntities db = new foodreceipeEntities();

        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult menu()
        {
            return View(db.menus.ToList());
        }

        public ActionResult reservation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult reservation(reservation r1)
        {
            db.reservations.Add(r1);
            db.SaveChanges();
            return View();
        }

        public ActionResult team()
        {
            return View(db.teams.ToList());
        }
        public ActionResult about()
        {
            return View();
        }

     
        public ActionResult specialdish()
        {
            return View(db.sp_dish.ToList());
        }
    }
}