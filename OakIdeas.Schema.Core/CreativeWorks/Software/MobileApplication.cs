using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Core.CreativeWorks.Software
{
    /// <summary>
    /// A mobile software application.
    /// </summary>
    /// <see cref="http://www.schema.org/MobileApplication"/>
    public class MobileApplication : SoftwareApplication
    {
        /// <summary>
        /// Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).
        /// </summary>
        public IEnumerable<string> CarrierRequirements { get; set; }
    }
}
