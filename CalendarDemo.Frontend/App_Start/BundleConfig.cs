namespace CalendarDemo.Frontend
{
    using System.Web.Optimization;

    /// <summary>
    /// Handles resource bundle configuration.
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Registers resource bundles.
        /// </summary>
        /// <param name="bundles">The <see cref="BundleCollection"/> to add bundles.</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-ui-router.js",
                "~/Scripts/angular-resource.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/app/app.js",
                "~/app/calendars/calendars.js"));

            bundles.Add(new StyleBundle("~/content/styles").Include(
                "~/Content/bootstrap.css",
                "~/Content/font-awesome.css",
                "~/Content/site.css"));
        }
    }
}