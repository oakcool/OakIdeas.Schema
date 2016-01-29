namespace OakIdeas.Schema.Core.Intangibles
{
    /// <summary>
    /// The rating of the video.
    /// </summary>
    /// <see cref="http://www.schema.org/Rating"/>
    public class Rating : Intangible
    {
        /// <summary>
        /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        public string BestRating { get; set; }
        /// <summary>
        /// The rating for the content.
        /// </summary>
        public string RatingValue { get; set; }
        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        public string WorstRatting { get; set; }
    }
}
