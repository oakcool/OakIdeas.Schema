using OakIdeas.Schema.Microdata.Intangibles;
using OakIdeas.Schema.Microdata.MedicalEntities;

namespace OakIdeas.Schema.Microdata.CreativeWorks.Medical
{
    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// </summary>
    /// <see cref="http://www.schema.org/ExercisePlan"/>
    public class ExercisePlan : CreativeWork
    {
        public MedicalEntity MedicalEntity { get; set; }
        public MedicalTherapy MedicalTherapy { get; set; }
        public PhysicalActivity PhysicalActivity { get; set; }
        public string ActivityDuration { get; set; }
        public string ActivityFrequency { get; set; }
        public string AdditionalVariable { get; set; }
        public string ExerciseType { get; set; }
        public string Intensity { get; set; }
        public int Repetitions { get; set; }
        public string RestPeriods { get; set; }
        public Energy Workload { get; set; }

    }
}
