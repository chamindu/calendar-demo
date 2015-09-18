namespace CalendarDemo.Api.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a paged collection with total count available.
    /// </summary>
    /// <typeparam name="T">The underlying model type.</typeparam>
    public class PagedCollection<T>
    {
        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the total count.
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the underlying model collection.
        /// </summary>
        public IEnumerable<T> Items { get; set; }
    }
}