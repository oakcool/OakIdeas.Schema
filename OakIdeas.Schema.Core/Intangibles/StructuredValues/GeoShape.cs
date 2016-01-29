using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Core.Intangibles.StructuredValues
{
    /// <summary>
    /// The geographic shape of a place.
    /// </summary>
    /// <see cref="http://www.schema.org/GeoShape"/>
    public class GeoShape :StructuredValue
    {
        /// <summary>
        /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. 
        /// A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
        /// </summary>
        public string Box { get; set; }
        /// <summary>
        /// A circle is the circular region of a specified radius centered at a specified latitude and longitude. 
        /// A circle is expressed as a pair followed by a radius in meters.
        /// </summary>
        public string Circle { get; set; }
        /// <summary>
        /// The elevation of a location.
        /// </summary>
        public string Elevation { get; set; }
        /// <summary>
        /// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
        /// </summary>
        public string Line { get; set; }
        /// <summary>
        /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. 
        /// A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
        /// </summary>
        public string Polygon { get; set; }
    }
}
