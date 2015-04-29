using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Microdata.Intangibles.StructuredValues;

namespace OakIdeas.Schema.Microdata.Products
{
    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// </summary>
    /// <see cref="http://www.schema.org/SomeProducts"/>
    public class SomeProducts : Product
    {
        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        public QuantitativeValue InventoryLevel { get; set; }
    }
}
