using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Microdata.Events;
using OakIdeas.Schema.Microdata.Intangibles;
using OakIdeas.Schema.Microdata.Intangibles.StructuredValues;
using OakIdeas.Schema.Microdata.Organizations;

namespace OakIdeas.Schema.Microdata
{
    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    /// <see cref="http://www.schema.org/Person"/>
    public class Person : Thing
    {
        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        public string AdditionalName { get; set; }
        /// <summary>
        /// Physical address of the item.
        /// </summary>
        public PostalAddress Address { get; set; }
        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        public Organization Affiliation { get; set; }
        /// <summary>
        /// An educational organizations that the person is an alumni of.
        /// </summary>
        public EducationalOrganization AlumniOf { get; set; }
        /// <summary>
        /// An award won by this person or for this creative work.
        /// </summary>
        public string Award { get; set; }
        /// <summary>
        /// Awards won by this person or for this creative work. (legacy spelling; see singular form, award)
        /// </summary>
        public IEnumerable<string> Awards { get; set; }
        /// <summary>
        /// Date of birth.
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        public IBrand Brand { get; set; }
        /// <summary>
        /// A child of the person.
        /// </summary>
        public IEnumerable<Person> Children { get; set; }
        /// <summary>
        /// A colleague of the person.
        /// </summary>
        public Person Colleage { get; set; }
        /// <summary>
        /// A colleague of the person (legacy spelling; see singular form, colleague).
        /// </summary>
        public IEnumerable<Person> Colleages { get; set; }
        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        public ContactPoint ContactPoint { get; set; }
        /// <summary>
        /// A contact point for a person or organization (legacy spelling; see singular form, contactPoint).
        /// </summary>
        public IEnumerable<ContactPoint> ContactPoints { get; set; }
        /// <summary>
        /// Date of death.
        /// </summary>
        public DateTime DeathDate { get; set; }
        /// <summary>
        /// The Dun & Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        public string Duns { get; set; }
        /// <summary>
        /// Email address.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the Name property.
        /// </summary>
        public string FamilyName { get; set; }
        /// <summary>
        /// The fax number.
        /// </summary>
        public string FaxNumber { get; set; }
        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        public Person Follows { get; set; }
        /// <summary>
        /// Gender of the person.
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the Name property.
        /// </summary>
        public string GivenName { get; set; }
        /// <summary>
        /// The Global Location Number (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        public string GlobalLocationNumber { get; set; }
        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        public IEnumerable<Place> HasPOS { get; set; }
        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        public ILocation HomeLocation { get; set; }
        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        public string HonorificPrefix { get; set; }
        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        public string HonorificSuffix { get; set; }
        /// <summary>
        /// A count of a specific user interactions with this item—for example, 20 UserLikes, 5 UserComments, or 300 UserDownloads. The user interaction type should be one of the sub types of UserInteraction.
        /// </summary>
        public IEnumerable<InterationCount> InterationCounts { get; set; }
        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        public string IsicV4 { get; set; }
        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        public string JobTitle { get; set; }
        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        public IEnumerable<Person> Knows { get; set; }
        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        public IEnumerable<Offer> MakesOffers { get; set; }
        /// <summary>
        /// An organization to which the person belongs.
        /// </summary>
        public Organization MemberOf { get; set; }
        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        public string Naics { get; set; }
        /// <summary>
        /// Nationality of the person.
        /// </summary>
        public string Nationality { get; set; }
        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        public IEnumerable<IOwn> Owns { get; set; }
        /// <summary>
        /// A parent of this person.
        /// </summary>
        public Person Parent { get; set; }
        /// <summary>
        /// A parents of the person (legacy spelling; see singular form, parent).
        /// </summary>
        public IEnumerable<Person> Parents { get; set; }
        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        public Event PerformIn { get; set; }
        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        public Person RelatedTo { get; set; }
        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        public IEnumerable<Demand> Seeks { get; set; }
        /// <summary>
        /// A sibling of the person.
        /// </summary>
        public Person Sibling { get; set; }
        /// <summary>
        /// A sibling of the person (legacy spelling; see singular form, sibling).
        /// </summary>
        public IEnumerable<Person> Siblings { get; set; }
        /// <summary>
        /// The person's spouse.
        /// </summary>
        public Person Spouse { get; set; }
        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        public string TaxId { get; set; }
        /// <summary>
        /// The telephone number.
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// The Value-added Tax ID of the organisation or person.
        /// </summary>
        public string VatId { get; set; }
        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        public ILocation WorkLocation { get; set; }
        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        public IEnumerable<Organization> WorksFor { get; set; }
    }
}
