using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Microdata.Intangibles.StructuredValues
{
    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
    /// <see cref="http://www.schema.org/QuantitativeValue"/>
    public class QuantitativeValue : StructuredValue
    {
        /// <summary>
        /// The upper of the product characteristic.
        /// </summary>
        public int MaxValue { get; set; }
        /// <summary>
        /// The lower value of the product characteristic.
        /// </summary>
        public int MinValue { get; set; }
        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters).
        /// </summary>
        public string UnitCode { get; set; }
        /// <summary>
        /// The value of the product characteristic.
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        public IValueReference ValueReference { get; set; }

    }
}
