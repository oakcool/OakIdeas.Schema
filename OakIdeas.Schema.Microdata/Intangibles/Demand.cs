using System;
using System.Collections.Generic;
using OakIdeas.Schema.Microdata.Intangibles.Enumerations;
using OakIdeas.Schema.Microdata.Intangibles.Enumerations.DeliveryMethods;
using OakIdeas.Schema.Microdata.Intangibles.Enumerations.ItemAvailabilities;
using OakIdeas.Schema.Microdata.Intangibles.Enumerations.PaymentMethods;
using OakIdeas.Schema.Microdata.Intangibles.StructuredValues;
using OakIdeas.Schema.Microdata.Intangibles.StructuredValues.PriceSpecifications;
using OakIdeas.Schema.Microdata.Places;
using OakIdeas.Schema.Microdata.Products;

namespace OakIdeas.Schema.Microdata.Intangibles
{
    public class Demand : Intangible
    {
        /// <summary>
        /// The payment method(s) accepted by seller for this offer.
        /// </summary>
        public PaymentMethod AcceptedPaymentMethod { get; set; }
        /// <summary>
        /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        /// </summary>
        public QuantitativeValue AdvanceBookingRequirement { get; set; }
        /// <summary>
        /// The availability of this item�for example In stock, Out of stock, Pre-order, etc.
        /// </summary>
        public ItemAvailability Availability { get; set; }
        /// <summary>
        /// The end of the availability of the product or service included in the offer.
        /// </summary>
        public DateTime AvailabilityEnds { get; set; }
        /// <summary>
        /// The beginning of the availability of the product or service included in the offer.
        /// </summary>
        public DateTime AvailabilityStarts { get; set; }
        /// <summary>
        /// The place(s) from which the offer can be obtained (e.g. store locations).
        /// </summary>
        public IEnumerable<Place> AvailableAtOrFrom { get; set; }
        /// <summary>
        /// The delivery method(s) available for this offer.
        /// </summary>
        public IEnumerable<DeliveryMethod> AvailableDeliveryMethod { get; set; }
        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        public BusinessFunction BusinessFunction { get; set; }
        /// <summary>
        /// The typical delay between the receipt of the order and the goods leaving the warehouse.
        /// </summary>
        public QuantitativeValue DeliveryLeadTime { get; set; }
        /// <summary>
        /// The type(s) of customers for which the given offer is valid.
        /// </summary>
        public BusinessEntityType EligibleCustomerType { get; set; }
        /// <summary>
        /// The duration for which the given offer is valid.
        /// </summary>
        public QuantitativeValue EligibleDuration { get; set; }
        /// <summary>
        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        /// </summary>
        public QuantitativeValue EligibleQuantity { get; set; }
        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.
        /// </summary>
        public IGeoInfo EligibleRegion { get; set; }
        /// <summary>
        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        /// </summary>
        public PriceSpecification EligibleTransactionVolume { get; set; }
        /// <summary>
        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero.
        /// </summary>
        public string Gtin13 { get; set; }
        /// <summary>
        /// The GTIN-14 code of the product, or the product to which the offer refers.
        /// </summary>
        public string Gtin14 { get; set; }
        /// <summary>
        /// The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN.
        /// </summary>
        public string Gtin8 { get; set; }
        /// <summary>
        /// This links to a node or nodes indicating the exact quantity of the products included in the offer.
        /// </summary>
        public TypeAndQuantityNode IncludesObject { get; set; }
        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        public QuantitativeValue InventoryLevel { get; set; }
        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        public OfferItemCondition ItemCondition { get; set; }
        /// <summary>
        /// The item being sold.
        /// </summary>
        public Product ItemOffered { get; set; }
        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        public string Mpn { get; set; }
        /// <summary>
        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        /// </summary>
        public PriceSpecification PriceSpecification { get; set; }
        /// <summary>
        /// The seller.
        /// </summary>
        public IEntity Seller { get; set; }
        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// The beginning of the validity of offer, price specification, or opening hours data.
        /// </summary>
        public DateTime ValidFrom { get; set; }
        /// <summary>
        /// The end of the validity of offer, price specification, or opening hours data.
        /// </summary>
        public DateTime ValidThrough { get; set; }
        /// <summary>
        /// The warranty promise(s) included in the offer.
        /// </summary>
        public WarrantyPromise Warranty { get; set; }
    }
}
