using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Core.Intangibles.Audiences
{
    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content
    /// </summary>
    /// <see cref="http://www.schema.org/ParentAudience"/>
    public class ParentAudience : PeopleAudience
    {
        /// <summary>
        /// Maximal age of the child
        /// </summary>
        public int ChildMaxAge { get; set; }
        /// <summary>
        /// Minimal age of the child
        /// </summary>
        public int ChildMinAge { get; set; }
    }
}
