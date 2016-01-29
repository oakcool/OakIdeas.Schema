using System.Collections.Generic;

namespace OakIdeas.Schema.Core.CreativeWorks.Articles
{
    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.
    /// </summary>
    /// <see cref="http://www.schema.org/Article"/>
    public class Article : CreativeWork
    {        
        /// <summary>
        /// The actual body of the article.
        /// </summary>
        public string ArticleBody { get; set; }
        /// <summary>
        /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
        /// </summary>
        public string ArticleSection { get; set; }
        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        public string PageEnd { get; set; }
        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        public string PageStart { get; set; }
        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        public string Pagination { get; set; }
        /// <summary>
        /// The number of words in the text of the Article.
        /// </summary>
        public int WordCount { get; set; }
    }
}
