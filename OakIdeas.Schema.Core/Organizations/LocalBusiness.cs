using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Core.CreativeWorks;
using OakIdeas.Schema.Core.CreativeWorks.MediaObjects;
using OakIdeas.Schema.Core.Intangibles;
using OakIdeas.Schema.Core.Intangibles.StructuredValues;

namespace OakIdeas.Schema.Core.Organizations
{
    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// </summary>
    /// <see cref="http://www.schema.org/LocalBusiness"/>
    public class LocalBusiness : Organization, IPlace
    {       
        /// <summary>
        /// The currency accepted (in ISO 4217 currency format).
        /// </summary>
        public string CurrenciesAccepted { get; set; }        
        /// <summary>
        /// Cash, credit card, etc.
        /// </summary>
        public string PaymentAccepted { get; set; }
        /// <summary>
        /// The price range of the business, for example $$$.
        /// </summary>
        public string PriceRange { get; set; }
        public PropertyValue AdditionalProperty { get; set; }        
        public AggregateRating AggregateRattings { get; set; }
        public string BranchCode { get; set; }
        public Place ContainedInPlace { get; set; }
        public Place ContainsPlace { get; set; }        
        public StructuredValue Geo { get; set; }        
        public Map HasMap { get; set; }
        public OppeningHoursSpecification OpeningHoursSpecification { get; set; }
        public Thing Photo { get; set; }        
    }
}
