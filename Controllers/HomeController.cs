using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace solucion_p1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Joseph Barral";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Bqj2020793@est.univalle.edu";

            return View();
        }
    }
}