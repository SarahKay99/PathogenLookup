using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pathogen_Lookup.Controllers
{
    // This is our data model.
    public class PathogenTypes
    { 
        public String Type { get; set; }
        public String URL { get; set; }
    }
    public class HomeController : Controller
    {
        // List of our data model
        static public List<PathogenTypes> PathogenTypeDB = new List<PathogenTypes>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}