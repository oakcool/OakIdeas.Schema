using OakIdeas.Schema.Core.Intangibles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Core.Intangibles
{
    /// <summary>
    /// A property, used to indicate attributes and relationships of some Thing; equivalent to rdf:Property.
    /// </summary>
    /// <see cref="http://www.schema.org/Property"/>
    public class Property : Thing
    {
        /// <summary>
        /// Relates a property to a class that is (one of) the type(s) the property is expected to be used on.
        /// </summary>
        public Class DomainIncludes { get; set; }
        /// <summary>
        /// Relates a property to a class that constitutes (one of) the expected type(s) for values of the property.
        /// </summary>
        public Class RangeIncludes { get; set; }
    }
}
