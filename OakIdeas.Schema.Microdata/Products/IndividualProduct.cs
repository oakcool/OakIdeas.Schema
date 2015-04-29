using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Microdata.Products
{
    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// </summary>
    /// <see cref="http://www.schema.org/IndividualProduct"/>
    public class IndividualProduct : Product
    {
        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        public string SerialNumber { get; set; }
    }
}
