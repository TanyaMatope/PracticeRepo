using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Our Story";

            return View();
        }

        public ActionResult Favourites()
        {
            ViewBag.Message = "My Favourite Comics";

            return View();
        }


        public ActionResult Location()
        {
            ViewBag.Message = "Location";

            return View();
        }

        public ActionResult LatestNews()
        {
            ViewBag.Message = "Bringing you the latest comics";

            return View();
        }
    }
}