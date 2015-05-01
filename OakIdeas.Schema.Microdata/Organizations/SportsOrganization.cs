using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Microdata.Organizations
{
    /// <summary>
    /// An educational organization.
    /// </summary>
    /// <see cref="http://www.schema.org/SportsOrganization"/>
    public class SportsOrganization: Organization
    {
        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        public string Sport { get; set; }
    }
}
