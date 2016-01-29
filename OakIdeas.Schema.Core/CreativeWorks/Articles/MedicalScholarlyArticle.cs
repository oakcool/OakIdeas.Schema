using System.Collections.Generic;

namespace OakIdeas.Schema.Core.CreativeWorks.Articles
{
    /// <summary>
    /// A scholarly article in the medical domain.
    /// </summary>
    /// <see cref="http://www.schema.org/MedicalScholarlyArticle"/>
    public class MedicalScholarlyArticle : ScholarlyArticle
    {
        /// <summary>
        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc. NOTE: Candidate for promotion to ScholarlyArticle.
        /// </summary>
        public IEnumerable<CreativeWork> Citation { get; set; }
        /// <summary>
        /// The type of the medical article, taken from the US NLM MeSH publication type catalog.
        /// </summary>
        public string PublicationType { get; set; }
    }
}
