using OakIdeas.Schema.Microdata.MedicalEntities;

namespace OakIdeas.Schema.Microdata.Intangibles.Audiences
{
    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
    /// <see cref="http://www.schema.org/PeopleAudience"/>
    public class PeopleAudience : Audience
    {
        /// <summary>
        /// Expectations for health conditions of target audience
        /// </summary>
        public MedicalCondition HealthCondition { get; set; }
        /// <summary>
        /// The gender of the person or audience.
        /// </summary>
        public string SuggestedGender { get; set; }
        /// <summary>
        /// Maximal age recommended for viewing content
        /// </summary>
        public int SuggestedMaxAge { get; set; }
        /// <summary>
        /// Minimal age recommended for viewing content
        /// </summary>
        public int SuggestedMinAge { get; set; }
    }
}
