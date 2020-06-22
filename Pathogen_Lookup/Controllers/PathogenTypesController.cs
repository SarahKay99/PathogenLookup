using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pathogen_Lookup.Models;

namespace Pathogen_Lookup.Controllers
{
    public class PathogenTypesController : Controller
    {
        private PathogenTypeDbContext db = new PathogenTypeDbContext();

        // GET: PathogenTypes
        public ActionResult Index()
        {
            return View(db.PathogenTypes.ToList());
        }

        // GET: PathogenTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PathogenType pathogenType = db.PathogenTypes.Find(id);
            if (pathogenType == null)
            {
                return HttpNotFound();
            }
            return View(pathogenType);
        }

        // GET: PathogenTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PathogenTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,URL")] PathogenType pathogenType)
        {
            if (ModelState.IsValid)
            {
                db.PathogenTypes.Add(pathogenType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pathogenType);
        }

        // GET: PathogenTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PathogenType pathogenType = db.PathogenTypes.Find(id);
            if (pathogenType == null)
            {
                return HttpNotFound();
            }
            return View(pathogenType);
        }

        // POST: PathogenTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,URL")] PathogenType pathogenType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pathogenType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pathogenType);
        }

        // GET: PathogenTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PathogenType pathogenType = db.PathogenTypes.Find(id);
            if (pathogenType == null)
            {
                return HttpNotFound();
            }
            return View(pathogenType);
        }

        // POST: PathogenTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PathogenType pathogenType = db.PathogenTypes.Find(id);
            db.PathogenTypes.Remove(pathogenType);
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
