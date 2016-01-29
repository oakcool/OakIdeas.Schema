using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Core.Intangibles
{
    /// <summary>
    /// Lists or enumerations—for example, a list of cuisines or music genres, etc.
    /// </summary>
    /// <see cref="http://www.schema.org/Enumeration"/>
    public class Enumeration : Intangible
    {
        //TODO: Give some thought on how to better address enumerataions
        private List<string> _members;
        public List<string> Members {
            get
            {
                if (_members == null)
                {
                    _members = new List<string>();
                }

                return _members;
            }
        }
        /// <summary>
        /// Relates a term (i.e. a property, class or enumeration) to one that supersedes it.
        /// </summary>
        public Intangible SupersededBy { get; set; }        
    }
}
