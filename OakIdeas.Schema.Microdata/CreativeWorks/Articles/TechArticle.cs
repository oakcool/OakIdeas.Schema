namespace OakIdeas.Schema.Microdata.CreativeWorks.Articles
{
    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
    /// <see cref="http://www.schema.org/TechArticle"/>
    public class TechArticle : Article
    {
        /// <summary>
        /// Prerequisites needed to fulfill steps in article.
        /// </summary>
        public string Dependencies { get; set; }
        /// <summary>
        /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
        /// </summary>
        public string ProficiencyLevel { get; set; }
    }
}
