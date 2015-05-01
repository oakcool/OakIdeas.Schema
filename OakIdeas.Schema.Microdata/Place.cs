using System.Collections.Generic;
using OakIdeas.Schema.Microdata.CreativeWorks;
using OakIdeas.Schema.Microdata.Events;
using OakIdeas.Schema.Microdata.Intangibles;
using OakIdeas.Schema.Microdata.Intangibles.StructuredValues;

namespace OakIdeas.Schema.Microdata
{
    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// </summary>
    /// <see cref="http://www.schema.org/Place"/>
    public class Place : Thing
    {
        /// <summary>
        /// Physical address of the item.
        /// </summary>
        public PostalAddress Address { get; set; }
        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        public IEnumerable<AggregateRating> AggregateRattings { get; set; }
        /// <summary>
        /// The basic containment relation between places.
        /// </summary>
        public Place ContainedIn { get; set; }
        /// <summary>
        /// Upcoming or past event associated with this place or organization.
        /// </summary>
        public Event Event { get; set; }
        /// <summary>
        /// Upcoming or past events associated with this place or organization (legacy spelling; see singular form, event).
        /// </summary>
        public IEnumerable<Event> Events { get; set; }
        /// <summary>
        /// The fax number.
        /// </summary>
        public string FaxNumber { get; set; }
        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        public Thing Geo { get; set; }
        /// <summary>
        /// The Global Location Number (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        public string GlobalLocationNumber { get; set; }
        /// <summary>
        /// A count of a specific user interactions with this item�for example, 20 UserLikes, 5 UserComments, or 300 UserDownloads. The user interaction type should be one of the sub types of UserInteraction.
        /// </summary>
        public IEnumerable<InterationCount> InterationCounts { get; set; }
        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        public string IsicV4 { get; set; }
        /// <summary>
        /// URL of an image for the logo of the item.
        /// </summary>
        public string Logo { get; set; }
        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        public string Map { get; set; }
        /// <summary>
        /// A URL to a map of the place (legacy spelling; see singular form, map).
        /// </summary>
        public string Maps { get; set; }
        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        public IEnumerable<OppeningHoursSpecification> OppeningHoursSpecifications { get; set; }
        /// <summary>
        /// A photograph of this place.
        /// </summary>
        public Thing Photo { get; set; }
        /// <summary>
        /// A review of the item.
        /// </summary>
        public Review Review { get; set; }
        /// <summary>
        /// Review of the item (legacy spelling; see singular form, review).
        /// </summary>
        public IEnumerable<Review> Reviews { get; set; }
        /// <summary>
        /// The telephone number.
        /// </summary>
        public string Telephone { get; set; }


    }
}
