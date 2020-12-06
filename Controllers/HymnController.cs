using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MeetingPlanner.DAL;
using MeetingPlanner.Models;

namespace MeetingPlanner.Controllers
{
    public class HymnController : Controller
    {
        private MeetingContext db = new MeetingContext();

        // GET: Hymn
        public ActionResult Index()
        {
            return View(db.Hymns.ToList());
        }

        // GET: Hymn/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hymn hymn = db.Hymns.Find(id);
            if (hymn == null)
            {
                return HttpNotFound();
            }
            return View(hymn);
        }

        // GET: Hymn/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hymn/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Number,Title")] Hymn hymn)
        {
            if (ModelState.IsValid)
            {
                db.Hymns.Add(hymn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hymn);
        }

        // GET: Hymn/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hymn hymn = db.Hymns.Find(id);
            if (hymn == null)
            {
                return HttpNotFound();
            }
            return View(hymn);
        }

        // POST: Hymn/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Number,Title")] Hymn hymn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hymn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hymn);
        }

        // GET: Hymn/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hymn hymn = db.Hymns.Find(id);
            if (hymn == null)
            {
                return HttpNotFound();
            }
            return View(hymn);
        }

        // POST: Hymn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hymn hymn = db.Hymns.Find(id);
            db.Hymns.Remove(hymn);
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
