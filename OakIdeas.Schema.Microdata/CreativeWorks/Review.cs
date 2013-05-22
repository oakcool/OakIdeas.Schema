using OakIdeas.Schema.Microdata.Intangibles;

namespace OakIdeas.Schema.Microdata.CreativeWorks
{
    /// <summary>
    /// The total time it takes to prepare and cook the recipe, in ISO 8601 duration format.
    /// </summary>
    /// <see cref="http://www.schema.org/Review"/>
    public class Review : CreativeWork
    {
        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        public Thing ItemReviewed { get; set; }
        /// <summary>
        /// The actual body of the review
        /// </summary>
        public string ReviewBody { get; set; }
        /// <summary>
        /// The rating given in this review. Note that reviews can themselves be rated. The reviewRating applies to rating given by the review. The aggregateRating property applies to the review itself, as a creative work.
        /// </summary>
        public Rating ReviewRating { get; set; }
    }
}