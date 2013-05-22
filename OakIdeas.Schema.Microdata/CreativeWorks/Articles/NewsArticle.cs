namespace OakIdeas.Schema.Microdata.CreativeWorks.Articles
{
    /// <summary>
    /// A news article
    /// </summary>
    /// <see cref="http://www.schema.org/NewsArticle"/>
    public class NewsArticle : Article
    {
        /// <summary>
        /// The location where the NewsArticle was produced.
        /// </summary>
        public string Dateline { get; set; }
        /// <summary>
        /// The number of the column in which the NewsArticle appears in the print edition.
        /// </summary>
        public string PrintColumn { get; set; }
        /// <summary>
        /// The edition of the print product in which the NewsArticle appears.
        /// </summary>
        public string PrintEdition { get; set; }
        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
        /// </summary>
        public string PrintPage { get; set; }
        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
        /// </summary>
        public string PrintSection { get; set; }
    }
}
