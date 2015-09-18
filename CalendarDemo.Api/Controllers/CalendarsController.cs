namespace CalendarDemo.Api.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using CalendarDemo.Api.Models;

    /// <summary>
    /// Calendars controller.
    /// </summary>
    public class CalendarsController : ApiController
    {
        /// <summary>
        /// Gets the list of calendars.
        /// </summary>
        /// <returns>An instance of <see cref="IEnumerable{Calendar}"/>.</returns>
        public IEnumerable<Calendar> Get()
        {
            return Calendar.GetCalendars();
        }
    }
}