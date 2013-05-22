using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Microdata.Intangibles.Enumerations.DeliveryMethods;

namespace OakIdeas.Schema.Microdata.Intangibles.StructuredValues.PriceSpecifications
{
    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
    /// <see cref="http://www.schema.org/DeliveryChargeSpecification"/>
    public class DeliveryChargeSpecification : PriceSpecification
    {
        public DeliveryMethod AppliesToDeliveryMethod { get; set; }
        public IGeoInfo EligibleRegion { get; set; }
    }
}
