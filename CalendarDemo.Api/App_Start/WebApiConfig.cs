namespace CalendarDemo.Api
{
    using System.Web.Http;

    /// <summary>
    /// Handles web API configuration.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers the Web API configuration settings.
        /// </summary>
        /// <param name="config">The <see cref="HttpConfiguration"/> to configure.</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
        }
    }
}
