using System.Collections.Generic;

namespace OakIdeas.Schema.Core.CreativeWorks
{
    /// <summary>
    /// A list of items of any sort—for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// </summary>
    /// <see cref="http://www.schema.org/ItemList"/>
    public class ItemList : CreativeWork
    {
        /// <summary>
        /// The items on the list
        /// </summary>
        public IEnumerable<ItemListElement> ItemListElements { get; set; }
        /// <summary>
        /// Type of ordering (e.g. Ascending, Descending, Unordered).
        /// </summary>
        public string ItemListOrder { get; set; }
    }
}
