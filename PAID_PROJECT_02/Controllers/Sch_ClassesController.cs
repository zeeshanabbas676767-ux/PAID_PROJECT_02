using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PAID_PROJECT_02.Data;
using PAID_PROJECT_02.Models;

namespace PAID_PROJECT_02.Controllers
{
    public class Sch_ClassesController : Controller
    {
        private PAID_PROJECT_02Context db = new PAID_PROJECT_02Context();

        // GET: Sch_Classes
        public ActionResult Index()
        {
            return View(db.Sch_Classes.ToList());
        }

        // GET: Sch_Classes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Classes sch_Classes = db.Sch_Classes.Find(id);
            if (sch_Classes == null)
            {
                return HttpNotFound();
            }
            return View(sch_Classes);
        }

        // GET: Sch_Classes/Create
        public ActionResult Create()
        {
            return View(new Sch_Classes());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CourseId,StudentId,EnrollmentDate,Status,CreatedDate,UpdatedDate")] Sch_Classes sch_Classes)
        {
            if (ModelState.IsValid)
            {
                db.Sch_Classes.Add(sch_Classes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sch_Classes);
        }

        // GET: Sch_Classes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Classes sch_Classes = db.Sch_Classes.Find(id);
            if (sch_Classes == null)
            {
                return HttpNotFound();
            }
            return View(sch_Classes);
        }

        // POST: Sch_Classes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CourseId,StudentId,EnrollmentDate,Status,CreatedDate,UpdatedDate")] Sch_Classes sch_Classes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sch_Classes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sch_Classes);
        }

        // GET: Sch_Classes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Classes sch_Classes = db.Sch_Classes.Find(id);
            if (sch_Classes == null)
            {
                return HttpNotFound();
            }
            return View(sch_Classes);
        }

        // POST: Sch_Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sch_Classes sch_Classes = db.Sch_Classes.Find(id);
            db.Sch_Classes.Remove(sch_Classes);
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
