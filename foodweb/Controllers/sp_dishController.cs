using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using foodweb.Models;

namespace foodweb.Controllers
{
    public class sp_dishController : Controller
    {
        private foodreceipeEntities db = new foodreceipeEntities();

        // GET: sp_dish
        public ActionResult Index()
        {
            var sp_dish = db.sp_dish.Include(s => s.category);
            return View(sp_dish.ToList());
        }

        // GET: sp_dish/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sp_dish sp_dish = db.sp_dish.Find(id);
            if (sp_dish == null)
            {
                return HttpNotFound();
            }
            return View(sp_dish);
        }

        // GET: sp_dish/Create
        public ActionResult Create()
        {
            ViewBag.catid = new SelectList(db.categories, "catid", "catname");
            return View();
        }

        // POST: sp_dish/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "dishid,dishname,catid,details,price,img")] sp_dish sp_dish, HttpPostedFileBase imgupload)
        {
            if (ModelState.IsValid)
            {
                imgupload.SaveAs(Server.MapPath("~/images/" + imgupload.FileName));
                sp_dish.img = imgupload.FileName;
                db.sp_dish.Add(sp_dish);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.catid = new SelectList(db.categories, "catid", "catname", sp_dish.catid);
            return View(sp_dish);
        }

        // GET: sp_dish/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sp_dish sp_dish = db.sp_dish.Find(id);
            if (sp_dish == null)
            {
                return HttpNotFound();
            }
            ViewBag.catid = new SelectList(db.categories, "catid", "catname", sp_dish.catid);
            return View(sp_dish);
        }

        // POST: sp_dish/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "dishid,dishname,catid,details,price,img")] sp_dish sp_dish)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sp_dish).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.catid = new SelectList(db.categories, "catid", "catname", sp_dish.catid);
            return View(sp_dish);
        }

        // GET: sp_dish/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sp_dish sp_dish = db.sp_dish.Find(id);
            if (sp_dish == null)
            {
                return HttpNotFound();
            }
            return View(sp_dish);
        }

        // POST: sp_dish/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sp_dish sp_dish = db.sp_dish.Find(id);
            db.sp_dish.Remove(sp_dish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
