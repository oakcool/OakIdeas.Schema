using System;
using OakIdeas.Schema.Microdata.CreativeWorks.MediaObjects;
using OakIdeas.Schema.Microdata.Places;

namespace OakIdeas.Schema.Microdata.CreativeWorks.Data
{
    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
    /// <see cref="http://www.schema.org/Dataset"/>
    public class Dataset : CreativeWork
    {
        /// <summary>
        /// A data catalog which contains a dataset.
        /// </summary>
        public DataCatalog Catalog { get; set; }
        /// <summary>
        /// A downloadable form of this dataset, at a specific location, in a specific format.
        /// </summary>
        public DataDownload Distribution { get; set; }
        /// <summary>
        /// The range of spatial applicability of a dataset, e.g. for a dataset of New York weather, the state of New York.
        /// </summary>
        public Place Spacial { get; set; }
        /// <summary>
        /// The range of temporal applicability of a dataset, e.g. for a 2011 census dataset, the year 2011 (in ISO 8601 time interval format).
        /// </summary>
        public DateTime Temporal { get; set; }
    }
}
