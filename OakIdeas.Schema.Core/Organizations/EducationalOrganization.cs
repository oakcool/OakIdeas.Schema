using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Core.Organizations
{
    /// <summary>
    /// An educational organization.
    /// </summary>
    /// <see cref="http://www.schema.org/EducationalOrganization"/>
    public class EducationalOrganization : Organization
    {
        /// <summary>
        /// Alumni of educational organization.
        /// Inverse property: alumniOf.
        /// </summary>
        public Person Alumni { get; set; }
    }
}
