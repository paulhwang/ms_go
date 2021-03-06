﻿using System.Web;
using System.Web.Optimization;

namespace go
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/phwang_js").Include(
                      "~/Scripts/phwang/phwang_class.js",
                      "~/Scripts/phwang/phwang_link_class.js",
                      "~/Scripts/phwang/phwang_session_class.js",
                      "~/Scripts/phwang/phwang_ajax_class.js"));

            bundles.Add(new ScriptBundle("~/bundles/account_sign_in_js").Include(
                      "~/Scripts/Account/account_sign_in.js"));

            bundles.Add(new ScriptBundle("~/bundles/account_sign_up_js").Include(
                      "~/Scripts/Account/account_sign_up.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
