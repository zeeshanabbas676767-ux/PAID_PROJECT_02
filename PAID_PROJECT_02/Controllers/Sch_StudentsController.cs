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
    public class Sch_StudentsController : Controller
    {
        private PAID_PROJECT_02Context db = new PAID_PROJECT_02Context();

        // GET: Sch_Students
        public ActionResult Index()
        {
            return View(db.Sch_Students.ToList());
        }

        // GET: Sch_Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Students sch_Students = db.Sch_Students.Find(id);
            if (sch_Students == null)
            {
                return HttpNotFound();
            }
            return View(sch_Students);
        }

        // GET: Sch_Students/Create
        public ActionResult Create()
        {
            var students = db.Sch_Classes.Select(p => new SelectListItem
            {
                Value = p.StudentId.ToString(),
                Text = p.StudentId.ToString()
            }).ToList();
            ViewBag.Student_ID = students;
            return View(new Sch_Students());
        }

        // POST: Sch_Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Student_Id,Student_Name,Address,City,Country,Email,Phone,Mobile,Enrollment_Date,Active,Deleted,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Sch_Students sch_Students)
        {
            if (ModelState.IsValid)
            {
                db.Sch_Students.Add(sch_Students);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sch_Students);
        }

        // GET: Sch_Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Students sch_Students = db.Sch_Students.Find(id);
            if (sch_Students == null)
            {
                return HttpNotFound();
            }
            return View(sch_Students);
        }

        // POST: Sch_Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Student_Id,Student_Name,Address,City,Country,Email,Phone,Mobile,Enrollment_Date,Active,Deleted,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Sch_Students sch_Students)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sch_Students).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sch_Students);
        }

        // GET: Sch_Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Students sch_Students = db.Sch_Students.Find(id);
            if (sch_Students == null)
            {
                return HttpNotFound();
            }
            return View(sch_Students);
        }

        // POST: Sch_Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sch_Students sch_Students = db.Sch_Students.Find(id);
            db.Sch_Students.Remove(sch_Students);
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
