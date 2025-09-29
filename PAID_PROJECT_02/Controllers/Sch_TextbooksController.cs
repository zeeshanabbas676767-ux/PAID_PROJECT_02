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
    public class Sch_TextbooksController : Controller
    {
        private PAID_PROJECT_02Context db = new PAID_PROJECT_02Context();

        // GET: Sch_Textbooks
        public ActionResult Index()
        {
            return View(db.Sch_Textbooks.ToList());
        }

        // GET: Sch_Textbooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Textbooks sch_Textbooks = db.Sch_Textbooks.Find(id);
            if (sch_Textbooks == null)
            {
                return HttpNotFound();
            }
            return View(sch_Textbooks);
        }

        // GET: Sch_Textbooks/Create
        public ActionResult Create()
        {
            return View(new Sch_Textbooks());
        }

        // POST: Sch_Textbooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CourseId,Title,Code,Description,ISBN,Price,Deleted,Active,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Sch_Textbooks sch_Textbooks)
        {
            if (ModelState.IsValid)
            {
                db.Sch_Textbooks.Add(sch_Textbooks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sch_Textbooks);
        }

        // GET: Sch_Textbooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Textbooks sch_Textbooks = db.Sch_Textbooks.Find(id);
            if (sch_Textbooks == null)
            {
                return HttpNotFound();
            }
            return View(sch_Textbooks);
        }

        // POST: Sch_Textbooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CourseId,Title,Code,Description,ISBN,Price,Deleted,Active,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate")] Sch_Textbooks sch_Textbooks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sch_Textbooks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sch_Textbooks);
        }

        // GET: Sch_Textbooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Textbooks sch_Textbooks = db.Sch_Textbooks.Find(id);
            if (sch_Textbooks == null)
            {
                return HttpNotFound();
            }
            return View(sch_Textbooks);
        }

        // POST: Sch_Textbooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sch_Textbooks sch_Textbooks = db.Sch_Textbooks.Find(id);
            db.Sch_Textbooks.Remove(sch_Textbooks);
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
