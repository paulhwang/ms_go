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
        public ActionResult Index()
        {
            return View();
        }
    }
}