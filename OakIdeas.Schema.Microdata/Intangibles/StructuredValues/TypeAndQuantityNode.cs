using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Microdata.Intangibles.Enumerations;
using OakIdeas.Schema.Microdata.Products;

namespace OakIdeas.Schema.Microdata.Intangibles.StructuredValues
{
    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
    /// <see cref="http://www.schema.org/TypeAndQuantityNode"/>
    public class TypeAndQuantityNode : StructuredValue
    {
        /// <summary>
        /// The quantity of the goods included in the offer.
        /// </summary>
        public int AmountOfThisGood { get; set; }
        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        public BusinessFunction BusinessFunction { get; set; }
        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        public Product TypeOfGood { get; set; }
        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters).
        /// </summary>
        public string UnitCode { get; set; }
    }
}
