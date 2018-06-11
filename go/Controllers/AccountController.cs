using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.WriteLine("in AccountRoot()");
            return View();
        }

        public ActionResult AccountSignIn()
        {
            Debug.WriteLine("in AccountSignIn()");
            return View();
        }

        public ActionResult AccountSignUp()
        {
            Debug.WriteLine("in AccountSignUp()");
            return View();
        }
    }
}