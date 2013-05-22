using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Microdata.CreativeWorks.Software
{
    /// <summary>
    /// Web applications.
    /// </summary>
    /// <see cref="http://www.schema.org/WebApplication"/>
    public class WebApplication : SoftwareApplication
    {
        /// <summary>
        /// Specifies browser requirements in human-readable text. For example,"requires HTML5 support".
        /// </summary>
        public IEnumerable<string> BrowserRequirements { get; set; }
    }
}
