using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace go.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        public ActionResult AccountRoot()
        {
            return View();
        }

        public ActionResult AccountSignIn()
        {
            return View();
        }

        public ActionResult AccountSignUp()
        {
            return View();
        }
    }
}