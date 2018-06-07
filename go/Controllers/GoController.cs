using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace go.Controllers
{
    public class GoController : Controller
    {
        // GET: Go
        public ActionResult GoRoot()
        {
            return View();
        }

        public ActionResult GoPlay()
        {
            return View();
        }

        public ActionResult GoSetup()
        {
            return View();
        }

    }
}