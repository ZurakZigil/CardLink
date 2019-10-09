using System.Web;
using System.Web.Optimization;

namespace CardLink_Project
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




            //Main
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/CardLink_Main.css"
                     //"~/Content/Lazaro.css",
                     //"~/Content/bootstrap-BootswatchLux.css"
                     //"~/Content/bootstrap.css",
                     //"~/Content/bootstrap-BootswatchSuperHero.css",
                     /* "~/Content/site.css"*/));




            //Login
            bundles.Add(new StyleBundle("~/Content/LoginCSS").Include(
                "~/Content/CardLink_Main.css",
                "~/Content/Login.css"
                //"~/Content/bootstrap-BootswatchLux.css"
                //"~/Content/bootstrap.css"
                //"~/Content/site.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/LoginJS").Include(
                "~/Scripts/Login.js",
                "~/Scripts/modernizr-*"
                ));


            //Login
            bundles.Add(new StyleBundle("~/Content/ProfileCSS").Include(
                //"~/Content/CardLink_Main.css",
                "~/Content/Profile.css"
                //"~/Content/bootstrap-BootswatchLux.css"
                //"~/Content/bootstrap.css"
                //"~/Content/site.css"
                ));
        }
    }
}
