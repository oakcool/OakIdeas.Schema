using System;
using System.Collections.Generic;
using OakIdeas.Schema.Core.CreativeWorks;
using OakIdeas.Schema.Core.CreativeWorks.MediaObjects;
using OakIdeas.Schema.Core.Intangibles;
using OakIdeas.Schema.Core.Intangibles.Audiences;
using OakIdeas.Schema.Core.Intangibles.StructuredValues;
using OakIdeas.Schema.Core.Products;

namespace OakIdeas.Schema.Core
{
    /// <summary>
    /// A product is anything that is made available for sale—for example, a pair of shoes, a concert ticket, or a car. Commodity services, like haircuts, can also be represented using this type.
    /// </summary>
    /// <see cref="http://www.schema.org/Product"/>
    public class Product : Thing
    {
        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        public AggregateRating AggregateRatting { get; set; }
        /// <summary>
        /// The intended audience of the item, i.e. the group for whom the item was created.
        /// </summary>
        public Audience Audience { get; set; }
        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        public Thing Brand { get; set; }
        /// <summary>
        /// The color of the product.
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// The depth of the product.
        /// </summary>
        public Thing Depth { get; set; }
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
        /// The height of the item.
        /// </summary>
        public Thing Height { get; set; }
        /// <summary>
        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        /// </summary>
        public Product IsAccessoryOrSparePartFor { get; set; }
        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        public Product IsRelatedTo { get; set; }
        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        public Product IsSimilarTo { get; set; }
        /// <summary>
        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        /// </summary>
        public OfferItemCondition ItemCondition { get; set; }
        /// <summary>
        /// URL of an image for the logo of the item.
        /// </summary>
        public ImageObject Logo { get; set; }
        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        public Organization Manufacturer { get; set; }
        /// <summary>
        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        /// </summary>
        public ProductModel Model { get; set; }
        /// <summary>
        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        /// </summary>
        public string Mpn { get; set; }
        /// <summary>
        /// An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, or give away tickets to an event.
        /// </summary>
        public Offer Offer { get; set; }
        /// <summary>
        /// The product identifier, such as ISBN. For example: <meta itemprop='productID' content='isbn:123-456-789'/>.
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        /// </summary>
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// A review of the item.
        /// </summary>
        public Review Review { get; set; }
        /// <summary>
        /// A review of the item. Supersedes reviews.
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        public QuantitativeValue Weight { get; set; }
        /// <summary>
        /// The width of the item.
        /// </summary>
        public Thing Width { get; set; }
    }
}
