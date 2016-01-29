using System;

namespace OakIdeas.Schema.Core.Intangibles.StructuredValues.PriceSpecifications
{
    /// <summary>
    /// A structured value representing a monetary amount. Typically, only the subclasses of this type are used for markup.
    /// </summary>
    /// <see cref="http://www.schema.org/PriceSpecification"/>
    public class PriceSpecification : StructuredValue
    {
        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        public QuantitativeValue EligibleQuantity { get; set; }
        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        public PriceSpecification EligibleTransactionVolume { get; set; }
        /// <summary>
        /// The highest price if the price is a range.
        /// </summary>
        public int MaxPrice { get; set; }
        /// <summary>
        /// The lowest price if the price is a range.
        /// </summary>
        public int MinPrice { get; set; }
        /// <summary>
        /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// The currency (in 3-letter ISO 4217 format) of the offer price or a price component, when attached to PriceSpecification and its subtypes.
        /// </summary>
        public string PriceCurrency { get; set; }
        /// <summary>
        /// The beginning of the validity of offer, price specification, or opening hours data.
        /// </summary>
        public DateTime ValidFrom { get; set; }
        /// <summary>
        /// The end of the validity of offer, price specification, or opening hours data.
        /// </summary>
        public DateTime ValidThrough { get; set; }
        /// <summary>
        /// Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
        /// </summary>
        public bool ValueAddedTaxIncluded { get; set; }
    }
}
