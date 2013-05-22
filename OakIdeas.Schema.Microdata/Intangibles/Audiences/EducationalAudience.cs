namespace OakIdeas.Schema.Microdata.Intangibles.Audiences
{
    /// <summary>
    /// An EducationalAudience
    /// </summary>
    /// <see cref="http://www.schema.org/EducationalAudience"/>
    public class EducationalAudience : Audience
    {
        /// <summary>
        /// An educationalRole of an EducationalAudience
        /// </summary>
        public string EducationalRole { get; set; }
    }
}
