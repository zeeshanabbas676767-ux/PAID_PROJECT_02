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
    public class Sch_DepartmentsController : Controller
    {
        private PAID_PROJECT_02Context db = new PAID_PROJECT_02Context();

        // GET: Sch_Departments
        public ActionResult Index()
        {
            return View(db.Sch_Departments.ToList());
        }

        // GET: Sch_Departments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Departments sch_Departments = db.Sch_Departments.Find(id);
            if (sch_Departments == null)
            {
                return HttpNotFound();
            }
            return View(sch_Departments);
        }

        // GET: Sch_Departments/Create
        public ActionResult Create()
        {
            return View(new Sch_Departments());
        }

        // POST: Sch_Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,DepartmentName,Description,Deleted,Active,RecordTimeStamp,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Sch_Departments sch_Departments)
        {
            if (ModelState.IsValid)
            {
                db.Sch_Departments.Add(sch_Departments);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sch_Departments);
        }

        // GET: Sch_Departments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Departments sch_Departments = db.Sch_Departments.Find(id);
            if (sch_Departments == null)
            {
                return HttpNotFound();
            }
            return View(sch_Departments);
        }

        // POST: Sch_Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,DepartmentName,Description,Deleted,Active,RecordTimeStamp,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Sch_Departments sch_Departments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sch_Departments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sch_Departments);
        }

        // GET: Sch_Departments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Departments sch_Departments = db.Sch_Departments.Find(id);
            if (sch_Departments == null)
            {
                return HttpNotFound();
            }
            return View(sch_Departments);
        }

        // POST: Sch_Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sch_Departments sch_Departments = db.Sch_Departments.Find(id);
            db.Sch_Departments.Remove(sch_Departments);
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
