using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Microdata.Intangibles.Enumerations.DeliveryMethods;
using OakIdeas.Schema.Microdata.Intangibles.Enumerations.PaymentMethods;

namespace OakIdeas.Schema.Microdata.Intangibles.StructuredValues.PriceSpecifications
{
    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
    /// <see cref="http://www.schema.org/PaymentChargeSpecification"/>
    public class PaymentChargeSpecification : PriceSpecification
    {
        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        public DeliveryMethod AppliesToDeliveryMethod { get; set; }
        /// <summary>
        /// The payment method(s) to which the payment charge specification applies.
        /// </summary>
        public PaymentMethod AppliesToPaymentMethod { get; set; }
    }
}
