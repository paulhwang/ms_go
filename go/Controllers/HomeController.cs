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

        public ActionResult login()
        {
            ViewBag.login = "login";
            return View();
        }

        public ActionResult menu()
        {
            ViewBag.login = "memu";
            return View();
        }

        public ActionResult config()
        {
            ViewBag.config = "config";
            return View();
        }

        public ActionResult Board()
        {
            ViewBag.board = "board";
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