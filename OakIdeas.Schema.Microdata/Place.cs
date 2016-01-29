using OakIdeas.Schema.Microdata.CreativeWorks;
using OakIdeas.Schema.Microdata.Intangibles;
using OakIdeas.Schema.Microdata.Intangibles.StructuredValues;
using OakIdeas.Schema.Microdata.CreativeWorks.MediaObjects;

namespace OakIdeas.Schema.Microdata
{
    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    /// <see cref="http://www.schema.org/Place"/>
    public class Place : Thing, IPlace
    {
        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.
        /// </summary>
        public PropertyValue AdditionalProperty { get; set; }
        /// <summary>
        /// Physical address of the item.
        /// </summary>
        public PostalAddress Address { get; set; }
        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        public AggregateRating AggregateRattings { get; set; }
        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs. 
        ///<example>
        ///For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch. 
        ///</example>
        /// </summary>
        public string BranchCode { get; set; }
        /// <summary>
        /// The basic containment relation between places.
        /// </summary>
        public Place ContainedInPlace { get; set; }
        /// <summary>
        /// The basic containment relation between a place and another that it contains. Inverse property: containsPlace.
        /// </summary>
        public Place ContainsPlace { get; set; }
        /// <summary>
        /// Upcoming or past event associated with this place or organization.
        /// </summary>
        public Event Event { get; set; }        
        /// <summary>
        /// The fax number.
        /// </summary>
        public string FaxNumber { get; set; }
        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        public StructuredValue Geo { get; set; } //TODO: See about the possibility of using a interface to better represent the possible types.
        /// <summary>
        /// The Global Location Number (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        public string GlobalLocationNumber { get; set; }
        /// <summary>
        /// A URL to a map of the place. Supersedes maps, map.
        /// </summary>
        public Map HasMap { get; set; }        
        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        public string IsicV4 { get; set; }
        /// <summary>
        /// An associated logo.
        /// </summary>
        public ImageObject Logo { get; set; }
        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        public OppeningHoursSpecification OpeningHoursSpecification { get; set; }        
        /// <summary>
        /// A photograph of this place.
        /// </summary>
        public Thing Photo { get; set; }
        /// <summary>
        /// A review of the item.
        /// </summary>
        public Review Review { get; set; }        
        /// <summary>
        /// The telephone number.
        /// </summary>
        public string Telephone { get; set; }
    }
}
