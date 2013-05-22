namespace OakIdeas.Schema.Microdata.Intangibles
{
    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// </summary>
    /// <see cref="http://www.schema.org/AlignmentObject"/>
    public class AlignmentObject : Intangible
    {
        /// <summary>
        /// A category of alignment between the learning resource and the framework node. Recommended values include: 'assesses', 'teaches', 'requires', 'textComplexity', 'readingLevel', 'educationalSubject', and 'educationLevel'.
        /// </summary>
        public string AlignmentType { get; set; }
        /// <summary>
        /// The framework to which the resource being described is aligned.
        /// </summary>
        public string EducationalFramework { get; set; }
        /// <summary>
        /// The description of a node in an established educational framework.
        /// </summary>
        public string TargetDescription { get; set; }
        /// <summary>
        /// The name of a node in an established educational framework.
        /// </summary>
        public string TargetName { get; set; }
        /// <summary>
        /// The URL of a node in an established educational framework.
        /// </summary>
        public string TargetUrl { get; set; }
    }
}
