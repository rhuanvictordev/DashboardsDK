using System.Web;
using System.Web.Optimization;

namespace DashboardsDK
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // js imports
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/jquery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bootstrap").Include("~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/toastr").Include("~/Scripts/toastr.js"));
            bundles.Add(new ScriptBundle("~/chart_js").Include("~/Scripts/Chart.js"));
            bundles.Add(new ScriptBundle("~/vue_js").Include("~/Scripts/vue.js"));

            // css imports
            bundles.Add(new StyleBundle("~/bundle_css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.css",
                      "~/Content/toastr.css"
            ));
        }
    }
}
