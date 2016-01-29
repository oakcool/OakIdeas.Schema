using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Core.Intangibles.Enumerations;

namespace OakIdeas.Schema.Core.Intangibles.StructuredValues.PriceSpecifications
{
    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// </summary>
    /// <see cref="http://www.schema.org/DeliveryChargeSpecification"/>
    public class DeliveryChargeSpecification : PriceSpecification
    {
        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        public DeliveryMethod AppliesToDeliveryMethod { get; set; }
        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.
        /// </summary>
        public GeoShape EligibleRegion { get; set; }
        
    }
}
