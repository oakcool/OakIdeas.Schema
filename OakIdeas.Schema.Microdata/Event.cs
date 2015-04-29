using System;
using System.Collections.Generic;
using OakIdeas.Schema.Microdata.Intangibles;

namespace OakIdeas.Schema.Microdata
{
    /// <summary>
    /// An event happening at a certain time at a certain location.
    /// </summary>
    /// <see cref="http://www.schema.org/Event"/>
    public class Event : Thing
    {
        /// <summary>
        /// A person or organization attending the event.
        /// </summary>
        public IEntity Attendee { get; set; }
        /// <summary>
        /// A person attending the event (legacy spelling; see singular form, attendee).
        /// </summary>
        public IEnumerable<IEntity> Attendees { get; set; }
        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.
        /// </summary>
        public DateTime Duration { get; set; }
        /// <summary>
        /// The end date and time of the event (in ISO 8601 date format).
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// The location of the event or organization.
        /// </summary>
        public ILocation Location { get; set; }
        /// <summary>
        /// An offer to sell this item—for example, an offer to sell a product, the DVD of a movie, or tickets to an event.
        /// </summary>
        public IEnumerable<Offer> Offers { get; set; }
        /// <summary>
        /// A performer at the event—for example, a presenter, musician, musical group or actor.
        /// </summary>
        public IEntity Performer { get; set; }
        /// <summary>
        /// The main performer or performers of the event—for example, a presenter, musician, or actor (legacy spelling; see singular form, performer).
        /// </summary>
        public IEnumerable<IEntity> Performers { get; set; }
        /// <summary>
        /// The start date and time of the event (in ISO 8601 date format).
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// An Event that is part of this event. For example, a conference event includes many presentations, each are a subEvent of the conference.
        /// </summary>
        public Event SubEvent { get; set; }
        /// <summary>
        /// Events that are a part of this event. For example, a conference event includes many presentations, each are subEvents of the conference (legacy spelling; see singular form, subEvent).
        /// </summary>
        public IEnumerable<Event> SubEvents { get; set; }
        /// <summary>
        /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
        /// </summary>
        public Event SuperEvent { get; set; }
    }
}
