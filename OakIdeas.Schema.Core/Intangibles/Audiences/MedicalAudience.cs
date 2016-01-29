using OakIdeas.Schema.Core.MedicalEntities;

namespace OakIdeas.Schema.Core.Intangibles.Audiences
{
    /// <summary>
    /// Target audiences for medical web pages. Enumerated type.
    /// </summary>
    /// <see cref="http://www.schema.org/MedicalAudience"/>
    public class MedicalAudience : PeopleAudience
    {
        public MedicalEntity MedicalEntity { get; set; }
    }
}
