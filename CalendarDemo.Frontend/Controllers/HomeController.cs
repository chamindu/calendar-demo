namespace CalendarDemo.Frontend.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// Home controller, servers the initial content for the SPA.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index action.
        /// </summary>
        /// <returns>The index view.</returns>
        public ActionResult Index()
        {
            return this.View();
        }
    }
}