using System;
using System.Collections.Generic;
using OakIdeas.Schema.Microdata.CreativeWorks;
using OakIdeas.Schema.Microdata.CreativeWorks.MediaObjects;
using OakIdeas.Schema.Microdata.Events.UserInteractions;
using OakIdeas.Schema.Microdata.Intangibles;
using OakIdeas.Schema.Microdata.Intangibles.Audiences;
using OakIdeas.Schema.Microdata.Organizations;

namespace OakIdeas.Schema.Microdata
{
    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
    /// <see cref="http://www.schema.org/CreativeWork"/>
    public class CreativeWork : Thing
    {
        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        public Thing About { get; set; }
        /// <summary>
        /// Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        public Person AccountablePerson { get; set; }
        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        public AggregateRating AggregateRatting { get; set; }
        /// <summary>
        /// A secondary title of the CreativeWork.
        /// </summary>
        public string AlternativeHeadline { get; set; }
        /// <summary>
        /// The media objects that encode this creative work. This property is a synonym for encodings.
        /// </summary>
        public IEnumerable<MediaObject> AssociatedMedia { get; set; }
        /// <summary>
        /// The intended audience of the item, i.e. the group for whom the item was created.
        /// </summary>
        public Audience Audience { get; set; }
        /// <summary>
        /// An embedded audio object.
        /// </summary>
        public IEnumerable<AudioObject> Audio { get; set; }
        /// <summary>
        /// The author of this content. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        public IEnumerable<IEntity> Author { get; set; }
        /// <summary>
        /// An award won by this person or for this creative work.
        /// </summary>
        public string Award { get; set; }
        /// <summary>
        /// Awards won by this person or for this creative work. (legacy spelling; see singular form, award)
        /// </summary>
        public IEnumerable<string> Awards { get; set; }
        /// <summary>
        /// Comments, typically from users, on this CreativeWork.
        /// </summary>
        public IEnumerable<UserComment> Comments { get; set; }
        /// <summary>
        /// The location of the content.
        /// </summary>
        public Place ContentLocation { get; set; }
        /// <summary>
        /// Official rating of a piece of content—for example,'MPAA PG-13'.
        /// </summary>
        public string ContentRating { get; set; }
        /// <summary>
        /// A secondary contributor to the CreativeWork.
        /// </summary>
        public IEnumerable<IEntity> Contributor { get; set; }
        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        public IEnumerable<IEntity> CopyrightHolder { get; set; }
        /// <summary>
        /// The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        public Int16 CopyrighYear { get; set; }
        /// <summary>
        /// The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.
        /// </summary>
        public IEnumerable<IEntity> Creator { get; set; }
        /// <summary>
        /// The date on which the CreativeWork was created.
        /// </summary>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// The date on which the CreativeWork was most recently modified.
        /// </summary>
        public DateTime DateModified { get; set; }
        /// <summary>
        /// Date of first broadcast/publication.
        /// </summary>
        public DateTime DatePublished { get; set; }
        /// <summary>
        /// A link to the page containing the comments of the CreativeWork.
        /// </summary>
        public string DiscussionUrl { get; set; }
        /// <summary>
        /// Specifies the Person who edited the CreativeWork.
        /// </summary>
        public Person Editor { get; set; }
        /// <summary>
        /// An alignment to an established educational framework.
        /// </summary>
        public AlignmentObject EducationalAlignment { get; set; }
        /// <summary>
        /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        /// </summary>
        public string EducationalUse { get; set; }
        /// <summary>
        /// A media object that encode this CreativeWork.
        /// </summary>
        public MediaObject Encoding { get; set; }
        /// <summary>
        /// The media objects that encode this creative work (legacy spelling; see singular form, encoding).
        /// </summary>
        public IEnumerable<MediaObject> Encodings { get; set; }
        /// <summary>
        /// Genre of the creative work
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Headline of the article
        /// </summary>
        public string HeadLine { get; set; }
        /// <summary>
        /// The language of the content. please use one of the language codes from the IETF BCP 47 standard.
        /// </summary>
        public string InLanguage { get; set; }
        /// <summary>
        /// A count of a specific user interactions with this item—for example, 20 UserLikes, 5 UserComments, or 300 UserDownloads. The user interaction type should be one of the sub types of UserInteraction.
        /// </summary>
        public IEnumerable<InterationCount> InterationCounts { get; set; }
        /// <summary>
        /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        public string InteractionType { get; set; }
        /// <summary>
        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html
        /// </summary>
        public string IsBasedOnUrl { get; set; }
        /// <summary>
        /// Indicates whether this content is family friendly.
        /// </summary>
        public bool IsFamilyFriendly { get; set; }
        /// <summary>
        /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        /// </summary>
        public IEnumerable<Thing> Mentions { get; set; }
        /// <summary>
        /// An offer to sell this item—for example, an offer to sell a product, the DVD of a movie, or tickets to an event.
        /// </summary>
        public IEnumerable<Offer> Offers { get; set; }
        /// <summary>
        /// Specifies the Person or Organization that distributed the CreativeWork.
        /// </summary>
        public IEntity Provider { get; set; }
        /// <summary>
        /// The publisher of the creative work.
        /// </summary>
        public Organization Publisher { get; set; }
        /// <summary>
        /// Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.
        /// </summary>
        public string PublishingPrinciples { get; set; }
        /// <summary>
        /// A review of the item.
        /// </summary>
        public IEnumerable<Review> Review { get; set; }
        /// <summary>
        /// Review of the item (legacy spelling; see singular form, review).
        /// </summary>
        public IEnumerable<Review> Reviews { get; set; }
        /// <summary>
        /// The Organization on whose behalf the creator was working.
        /// </summary>
        public Organization SourceOrganization { get; set; }
        /// <summary>
        /// The textual content of this CreativeWork.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// A thumbnail image relevant to the Thing.
        /// </summary>
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'P30M', 'P1H25M'.
        /// </summary>
        public string TimeRequired { get; set; }
        /// <summary>
        /// The typical range of ages the content's intendedEndUser, for example '7-9', '11-'.
        /// </summary>
        public string TypicalAgeRange { get; set; }
        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        public Int16 Version { get; set; }
        /// <summary>
        /// An embedded video object.
        /// </summary>
        public VideoObject Video { get; set; }

    }
}
