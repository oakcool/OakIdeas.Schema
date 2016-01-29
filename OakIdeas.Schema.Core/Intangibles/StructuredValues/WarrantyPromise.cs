using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Core.Intangibles.Enumerations;

namespace OakIdeas.Schema.Core.Intangibles.StructuredValues
{
    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// </summary>
    /// <see cref="http://www.schema.org/WarrantyPromise"/>
    public class WarrantyPromise : StructuredValue
    {
        public QuantitativeValue DurationOfWarranty { get; set; }
        public WarrantyScope WarrantyScope { get; set; }
    }
}
