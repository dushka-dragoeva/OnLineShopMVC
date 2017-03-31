using System.Web;
using System.Web.Optimization;

namespace OnLineShop.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/masonry").Include(
                    "~/Scripts/masonry.pkgd.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/imagesloaded").Include(
                    "~/Scripts/imagesloaded.js"));

            bundles.Add(new ScriptBundle("~/bundles/classie").Include(
                    "~/Scripts/classie.js"));

            bundles.Add(new ScriptBundle("~/bundles/AnimOnScroll").Include(
                    "~/Scripts/AnimOnScroll.js"));

              bundles.Add(new ScriptBundle("~/bundles/html5shiv").Include(
                    "~/Scripts/html5shiv.js"));

            bundles.Add(new ScriptBundle("~/bundles/respond").Include(
                  "~/Scripts/respond.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizrcustom").Include(
                  "~/Scripts/modernizr.custom.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/bootstrap-theme.css",
                  "~/Content/site.css",
                   "~/Content/image-effects.css",
                   "~/Content/normalize.css",
                   "~/Content/component.css",
                   "~/Content/font-awesome.css",
                   "~/Content/font-awesome-ie7.css",
                   "~/Content/html5shiv.js"
                  ));
        }
    }
}
