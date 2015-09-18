namespace CalendarDemo.Api.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using CalendarDemo.Api.Models;
    using System;

    /// <summary>
    /// Calendars controller.
    /// </summary>
    public class CalendarsController : ApiController
    {
        /// <summary>
        /// Holds the dummy calendar data.
        /// </summary>
        private static IEnumerable<Calendar> calendars;

        /// <summary>
        /// Initializes static members of the <see cref="CalendarsController"/> class and populates the dummy calendar
        /// data.
        /// </summary>
        static CalendarsController()
        {
            calendars = Enumerable.Range(0, 100)
                .Select(i => new Calendar()
                {
                    Name = "Calendar " + i,
                    Image = "http://lorempixel.com/180/180/abstract/" + ((i % 10) + 1),
                    SubscriberCount = new Random().Next(100, 150000)
                });
        }

        /// <summary>
        /// Gets the list of calendars.
        /// </summary>
        /// <param name="offset">The offset used for paging.</param>
        /// <param name="limit">The limit used for paging.</param>
        /// <returns>An instance of <see cref="PagedCollection{Calendar}"/>.</returns>
        public PagedCollection<Calendar> Get(int offset = 0, int limit = 5)
        {
            PagedCollection<Calendar> result = new PagedCollection<Calendar>();
            result.Items = calendars.Skip(offset).Take(limit);
            result.TotalCount = calendars.Count();
            result.Offset = offset;
            result.Limit = limit;

            return result;
        }
    }
}