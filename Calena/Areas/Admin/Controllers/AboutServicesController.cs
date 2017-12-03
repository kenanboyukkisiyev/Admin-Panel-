using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Calena.Models;

namespace Calena.Areas.Admin.Controllers
{
    public class AboutServicesController : Controller
    {
        private CalenaEntities db = new CalenaEntities();

        // GET: Admin/AboutServices
        public ActionResult Index()
        {
            if (Session["logined"] != null)
            {
                return View(db.AboutServices.ToList());
            }
            else
            {
                return RedirectToAction("index", "Home");
            }

          
        }

        // GET: Admin/AboutServices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutService aboutService = db.AboutServices.Find(id);
            if (aboutService == null)
            {
                return HttpNotFound();
            }
            return View(aboutService);
        }

        // GET: Admin/AboutServices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Value")] AboutService aboutService)
        {
            if (ModelState.IsValid)
            {
                db.AboutServices.Add(aboutService);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutService);
        }

        // GET: Admin/AboutServices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutService aboutService = db.AboutServices.Find(id);
            if (aboutService == null)
            {
                return HttpNotFound();
            }
            return View(aboutService);
        }

        // POST: Admin/AboutServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Value")] AboutService aboutService)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutService).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutService);
        }

        // GET: Admin/AboutServices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutService aboutService = db.AboutServices.Find(id);
            if (aboutService == null)
            {
                return HttpNotFound();
            }
            return View(aboutService);
        }

        // POST: Admin/AboutServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutService aboutService = db.AboutServices.Find(id);
            db.AboutServices.Remove(aboutService);
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
