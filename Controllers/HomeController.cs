using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using PathogenLookup.Models;

/// <summary>
/// File: HomeController.cs
/// Job: To control functionality of the .cshtml pages under Views -> Home
/// </summary>

namespace PathogenLookup.Controllers
{
    public class HomeController : Controller
    {
        private PathogenTypeDBContext db = new PathogenTypeDBContext();

        /// <summary>
        /// Function: Index()
        /// Job: To return the view page Home/Index with a reference to the PathogenTypeDBContext list db.
        /// </summary>
        public ActionResult Index()
        {
            return View(db.PathogenTypes.ToList());
        }

        /// <summary>
        /// Function: About()
        /// Job: To return the view page Home/About. This page is not built on in the final application.
        /// </summary>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Function: Contact()
        /// Job: To return the view page Home/Contact. This page is not built on in the final application.
        /// </summary>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}