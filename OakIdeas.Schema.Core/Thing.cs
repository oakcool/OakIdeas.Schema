using OakIdeas.Schema.Core.CreativeWorks.MediaObjects;

namespace OakIdeas.Schema.Core
{
    /// <summary>
    /// The most generic type of item.
    /// </summary>
    /// <see cref="http://www.schema.org/Thing"/>
    public class Thing
    {
        public virtual string ItemType
        {
            get { return "http://www.schema.org/" + this.GetType().Name; }
        }
        /// <summary>
        /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
        /// </summary>
        public string AdditionalType { get; set; }
        /// <summary>
        /// An alias for the item.
        /// </summary>
        public string AlternateName { get; set; }
        /// <summary>
        /// A short description of the item.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// An image of the item. This can be a URL or a fully described <see cref="ImageObject"/>.
        /// </summary>
        public ImageObject Image { get; set; }
        /// <summary>
        /// Indicates a page (or other <see cref="CreativeWork"/>) for which this thing is the main entity being described. 
        /// </summary>
        public CreativeWork MainEntityOfPage { get; set; }
        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
        /// </summary>
        public Action PotentialAction { get; set; }
        /// <summary>
        /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Freebase page, or official website.
        /// </summary>
        public string SameAs { get; set; }
        /// <summary>
        /// URL of the item.
        /// </summary>
        public string Url { get; set; }

    }
}
