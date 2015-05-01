namespace OakIdeas.Schema.Microdata.CreativeWorks.Medical
{
    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    /// <see cref="http://www.schema.org/Diet"/>
    public class Diet : CreativeWork
    {
        /// <summary>
        /// Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.
        /// </summary>
        public string DietFeatures { get; set; }
        /// <summary>
        /// People or organizations that endorse the plan.
        /// </summary>
        public Thing Endorsers { get; set; }
        /// <summary>
        /// Medical expert advice related to the plan.
        /// </summary>
        public string ExpertConsiderations { get; set; }
        /// <summary>
        /// Descriptive information establishing the overarching theory/philosophy of the plan. May include the rationale for the name, the population where the plan first came to prominence, etc.
        /// </summary>
        public string Overview { get; set; }
        /// <summary>
        /// Specific physiologic benefits associated to the plan.
        /// </summary>
        public string PhysiologicalBenefits { get; set; }
        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        public string ProprietaryName { get; set; }
        /// <summary>
        /// Specific physiologic risks associated to the plan.
        /// </summary>
        public string Risks { get; set; }
    }
}
