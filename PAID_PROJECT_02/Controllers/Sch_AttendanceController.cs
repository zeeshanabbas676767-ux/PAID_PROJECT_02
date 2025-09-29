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
    public class Sch_AttendanceController : Controller
    {
        private PAID_PROJECT_02Context db = new PAID_PROJECT_02Context();

        // GET: Sch_Attendance
        public ActionResult Index()  
        {
            return View(db.Sch_Attendance.ToList());
        }

        // GET: Sch_Attendance/Details/5
        public ActionResult Details(int? id)
        {
            Sch_Attendance sch_Attendance = db.Sch_Attendance.Find(id);
            return View(sch_Attendance);
        }

        // GET: Sch_Attendance/Create
        public ActionResult Create()
        {
            var students = db.Sch_Classes.Select(p => new SelectListItem
            {
                Value = p.StudentId.ToString(),
                Text = p.StudentId.ToString()
            }).ToList();
            ViewBag.Student_ID = students;
            return View(new Sch_Attendance());
        }

        // POST: Sch_Attendance/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentId,ClassId,AttendanceDate,Status,Deleted,Active,CreatedDate,UpdatedDate")] Sch_Attendance sch_Attendance)
        {
            if (ModelState.IsValid)
            {
                db.Sch_Attendance.Add(sch_Attendance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sch_Attendance);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var sch_Attendance = db.Sch_Attendance.Find(id);
            if (sch_Attendance == null)
                return HttpNotFound();

            return View(sch_Attendance);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentId,ClassId,AttendanceDate,Status,Deleted,Active,CreatedDate,UpdatedDate")] Sch_Attendance sch_Attendance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sch_Attendance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sch_Attendance);
        }

        // GET: Sch_Attendance/Delete/5
        public ActionResult Delete(int? id)
        {
            Sch_Attendance sch_Attendance = db.Sch_Attendance.Find(id);
            return View(sch_Attendance);
        }

        //// POST: Sch_Attendance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sch_Attendance sch_Attendance = db.Sch_Attendance.Find(id);
            db.Sch_Attendance.Remove(sch_Attendance);
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
