using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using com.bitforce.lab4_clo.Models;

namespace com.bitforce.lab4_clo.Controllers
{
    public class ServiceAreasController : Controller
    {
        private CLOContext db = new CLOContext();

        // GET: ServiceAreas
        public ActionResult Index()
        {
            return View(db.ServiceAreas.ToList());
        }

        // GET: ServiceAreas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceArea serviceArea = db.ServiceAreas.Find(id);
            if (serviceArea == null)
            {
                return HttpNotFound();
            }
            return View(serviceArea);
        }

        // GET: ServiceAreas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceAreas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address,Description")] ServiceArea serviceArea)
        {
            if (ModelState.IsValid)
            {
                db.ServiceAreas.Add(serviceArea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviceArea);
        }

        // GET: ServiceAreas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceArea serviceArea = db.ServiceAreas.Find(id);
            if (serviceArea == null)
            {
                return HttpNotFound();
            }
            return View(serviceArea);
        }

        // POST: ServiceAreas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,Description")] ServiceArea serviceArea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceArea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviceArea);
        }

        // GET: ServiceAreas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceArea serviceArea = db.ServiceAreas.Find(id);
            if (serviceArea == null)
            {
                return HttpNotFound();
            }
            return View(serviceArea);
        }

        // POST: ServiceAreas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceArea serviceArea = db.ServiceAreas.Find(id);
            db.ServiceAreas.Remove(serviceArea);
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
