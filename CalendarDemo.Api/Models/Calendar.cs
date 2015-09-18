namespace CalendarDemo.Api.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Represents a calendar.
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Gets or sets the image name of the calendar.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the name of the calendar.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the subscriber count.
        /// </summary>
        public int SubscriberCount { get; set; }
    }
}