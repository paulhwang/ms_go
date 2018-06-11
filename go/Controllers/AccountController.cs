using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        [HttpGet]
        public ActionResult AccountSignInReq()
        {
            Debug.WriteLine("in AccountSignInReq()");
            if (Request == null)
                Debug.WriteLine("null data");
            else
            {
                NameValueCollection header = Request.Headers;
                String data = header.Get("phwangajaxrequest");
                Debug.WriteLine(data);
            }
            return View();
        }

        public ActionResult AccountSignUp()
        {
            Debug.WriteLine("in AccountSignUp()");
            return View();
        }
    }
}