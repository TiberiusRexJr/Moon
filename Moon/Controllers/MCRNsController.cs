using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Moon.Models;

namespace Moon.Controllers
{
    public class MCRNsController : Controller
    {
        private MoonEntities db = new MoonEntities();

        // GET: MCRNs
        public ActionResult Index()
        {
            return View(db.MCRNs.ToList());
        }

        // GET: MCRNs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MCRN mCRN = db.MCRNs.Find(id);
            if (mCRN == null)
            {
                return HttpNotFound();
            }
            return View(mCRN);
        }

        // GET: MCRNs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MCRNs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Email,Pin")] MCRN mCRN)
        {
            if (ModelState.IsValid)
            {
                db.MCRNs.Add(mCRN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mCRN);
        }

        // GET: MCRNs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MCRN mCRN = db.MCRNs.Find(id);
            if (mCRN == null)
            {
                return HttpNotFound();
            }
            return View(mCRN);
        }

        // POST: MCRNs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Email,Pin")] MCRN mCRN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mCRN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mCRN);
        }

        // GET: MCRNs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MCRN mCRN = db.MCRNs.Find(id);
            if (mCRN == null)
            {
                return HttpNotFound();
            }
            return View(mCRN);
        }

        // POST: MCRNs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MCRN mCRN = db.MCRNs.Find(id);
            db.MCRNs.Remove(mCRN);
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
