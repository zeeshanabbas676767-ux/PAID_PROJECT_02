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
    public class Sch_InventoryController : Controller
    {
        private PAID_PROJECT_02Context db = new PAID_PROJECT_02Context();

        // GET: Sch_Inventory
        public ActionResult Index()
        {
            return View(db.Sch_Inventory.ToList());
        }

        // GET: Sch_Inventory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Inventory sch_Inventory = db.Sch_Inventory.Find(id);
            if (sch_Inventory == null)
            {
                return HttpNotFound();
            }
            return View(sch_Inventory);
        }

        // GET: Sch_Inventory/Create
        public ActionResult Create()
        {
            return View(new Sch_Inventory());
        }

        // POST: Sch_Inventory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ResourceId,ResourceName,InStock,Quantity,Rack,Shelf,Condition,Deleted,Active,CreatedDate,UpdatedDate")] Sch_Inventory sch_Inventory)
        {
            if (ModelState.IsValid)
            {
                db.Sch_Inventory.Add(sch_Inventory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sch_Inventory);
        }

        // GET: Sch_Inventory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Inventory sch_Inventory = db.Sch_Inventory.Find(id);
            if (sch_Inventory == null)
            {
                return HttpNotFound();
            }
            return View(sch_Inventory);
        }

        // POST: Sch_Inventory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ResourceId,ResourceName,InStock,Quantity,Rack,Shelf,Condition,Deleted,Active,CreatedDate,UpdatedDate")] Sch_Inventory sch_Inventory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sch_Inventory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sch_Inventory);
        }

        // GET: Sch_Inventory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sch_Inventory sch_Inventory = db.Sch_Inventory.Find(id);
            if (sch_Inventory == null)
            {
                return HttpNotFound();
            }
            return View(sch_Inventory);
        }

        // POST: Sch_Inventory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sch_Inventory sch_Inventory = db.Sch_Inventory.Find(id);
            db.Sch_Inventory.Remove(sch_Inventory);
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
