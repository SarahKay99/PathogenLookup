using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PathogenLookup.Models;

/// <summary>
/// File: PathogenTypesController.cs
/// Job: To control functionality of the .cshtml pages under Views -> PathogenTypes
/// </summary>

namespace PathogenLookup.Controllers
{
    public class PathogenTypesController : Controller
    {
        private PathogenTypeDBContext db = new PathogenTypeDBContext();

        // GET: PathogenTypes
        /// <summary>
        /// Function: Index()
        /// Job: To return the view page under PathogenTypes/Index with a reference to the PathogenTypeDBContext list db.
        /// </summary>
        [Authorize]
        public ActionResult Index()
        {
            return View(db.PathogenTypes.ToList());
        }

        // GET: PathogenTypes/Details/5
        [Authorize]
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
        /// <summary>
        /// Function: Create()
        /// Job: To return the view page under PathogenTypes/Create.
        /// </summary>
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: PathogenTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "ID,Name,URL")] PathogenType pathogenType)
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
        /// <summary>
        /// Function: Edit()
        /// Job: To return the view page under PathogenTypes/Edit.
        /// </summary>
        [Authorize]
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "ID,Name,URL")] PathogenType pathogenType)
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
        /// <summary>
        /// Function: Delete()
        /// Job: To return the view page under PathogenTypes/Delete.
        /// </summary>
        [Authorize]
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
