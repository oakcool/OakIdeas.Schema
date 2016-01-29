using OakIdeas.Schema.Core.Intangibles.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Core.Intangibles.StructuredValues
{
    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
    /// <see cref="http://www.schema.org/EngineSpecification"/>
    public class EngineSpecification : StructuredValue
    {
        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        public QualitativeValue FuelType { get; set; }
    }
}
