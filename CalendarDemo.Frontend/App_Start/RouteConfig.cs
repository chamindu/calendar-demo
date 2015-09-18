namespace CalendarDemo.Frontend
{
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// Handles route configuration.
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Registers all routes in the application.
        /// </summary>
        /// <param name="routes">The <see cref="RouteCollection"/> to add routes.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}