using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace go.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.phwang = "phwang";
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

        public ActionResult Menu()
        {
            ViewBag.menu = "Menu";
            return View();
        }

        public ActionResult Board()
        {
            ViewBag.board = "Board";
            return View();
        }

        public ActionResult Config()
        {
            ViewBag.config = "Config";
            return View();
        }
    }
}