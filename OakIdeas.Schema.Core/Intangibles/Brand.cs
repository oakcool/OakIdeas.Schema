using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Core.CreativeWorks.MediaObjects;

namespace OakIdeas.Schema.Core.Intangibles
{
    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    /// <see cref="http://www.schema.org/Brand"/>
    public class Brand : Intangible
    {
        /// <summary>
        /// URL of an image for the logo of the item.
        /// </summary>
        public ImageObject Logo { get; set; }
    }
}
