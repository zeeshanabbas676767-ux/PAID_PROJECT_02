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
    public class Sch_CoursesController : Controller
    {
        private PAID_PROJECT_02Context db = new PAID_PROJECT_02Context();

        // GET: Sch_Courses
        public ActionResult Index()
        {
            return View(db.Sch_Courses.ToList());
        }

        // GET: Sch_Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Courses sch_Courses = db.Sch_Courses.Find(id);
            if (sch_Courses == null)
            {
                return HttpNotFound();
            }
            return View(sch_Courses);
        }

        // GET: Sch_Courses/Create
        public ActionResult Create()
        {
            return View(new Sch_Courses());
        }

        // POST: Sch_Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DepartmentId,CourseName,Code,Description,Credits,Active,Deleted,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Sch_Courses sch_Courses)
        {
            if (ModelState.IsValid)
            {
                db.Sch_Courses.Add(sch_Courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sch_Courses);
        }

        // GET: Sch_Courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Courses sch_Courses = db.Sch_Courses.Find(id);
            if (sch_Courses == null)
            {
                return HttpNotFound();
            }
            return View(sch_Courses);
        }

        // POST: Sch_Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DepartmentId,CourseName,Code,Description,Credits,Active,Deleted,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Sch_Courses sch_Courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sch_Courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sch_Courses);
        }

        // GET: Sch_Courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Courses sch_Courses = db.Sch_Courses.Find(id);
            if (sch_Courses == null)
            {
                return HttpNotFound();
            }
            return View(sch_Courses);
        }

        // POST: Sch_Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sch_Courses sch_Courses = db.Sch_Courses.Find(id);
            db.Sch_Courses.Remove(sch_Courses);
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
