using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Microdata.Intangibles.StructuredValues
{
    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property. 
    /// </summary>
    /// <see cref="http://www.schema.org/PropertyValue"/>
    public class PropertyValue : StructuredValue
    {
        /// <summary>
        /// The upper value of some characteristic or property.
        /// </summary>
        public double MaxValue { get; set; }
        /// <summary>
        /// The lower value of some characteristic or property.
        /// </summary>
        public double MinValue { get; set; }
        /// <summary>
        /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3) a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry). Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
        /// </summary>
        public string PropertyID { get; set; }
        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        public string UnitCode { get; set; }
        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for unitCode.
        /// </summary>
        public string UnitText { get; set; }
        /// <summary>
        /// The value of the quantitative value or property value node. For QuantitativeValue, the recommended type for values is 'Number'. For PropertyValue, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        public Intangible ValueReference { get; set; }
        //TODO: Figure out how to best represent the possible accepted types for ValueReference, quite possibly a interface
    }
}
