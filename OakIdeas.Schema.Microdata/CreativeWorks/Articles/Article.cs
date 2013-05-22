using System.Collections.Generic;

namespace OakIdeas.Schema.Microdata.CreativeWorks.Articles
{
    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.
    /// </summary>
    /// <see cref="http://www.schema.org/Article"/>
    public class Article : CreativeWork
    {
        public override string ItemType
        {
            get
            {
                return "http://www.schema.org/Article";
            }
        }
        /// <summary>
        /// The actual body of the article.
        /// </summary>
        public string ArticleBody { get; set; }
        /// <summary>
        /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
        /// </summary>
        public IEnumerable<string> Sections { get; set; }
        /// <summary>
        /// The number of words in the text of the Article.
        /// </summary>
        public int WordCount { get; set; }
    }
}
