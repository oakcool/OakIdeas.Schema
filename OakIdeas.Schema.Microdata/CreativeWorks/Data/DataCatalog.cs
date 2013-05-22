namespace OakIdeas.Schema.Microdata.CreativeWorks.Data
{
    /// <summary>
    /// A collection of datasets.
    /// </summary>
    /// <see cref="http://www.schema.org/DataCatalog"/>
    public class DataCatalog : CreativeWork
    {
        /// <summary>
        /// A dataset contained in a catalog.
        /// </summary>
        public Dataset Dataset { get; set; }
    }
}
