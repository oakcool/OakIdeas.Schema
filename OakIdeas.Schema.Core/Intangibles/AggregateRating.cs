using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Core.Intangibles
{
    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
    /// <see cref="http://www.schema.org/AggregateRating"/>
    public class AggregateRating :Rating
    {
        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        public Thing ItemReviewed { get; set; }
        /// <summary>
        /// The count of total number of ratings.
        /// </summary>
        public int RatingCount { get; set; }
        /// <summary>
        /// The count of total number of reviews.
        /// </summary>
        public int ReviewCount { get; set; }
    }
}
