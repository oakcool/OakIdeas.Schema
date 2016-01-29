using System;
using System.Collections.Generic;
using OakIdeas.Schema.Core.CreativeWorks.MediaObjects;
using OakIdeas.Schema.Core.CreativeWorks.Music;
using OakIdeas.Schema.Core.Organizations;

namespace OakIdeas.Schema.Core.CreativeWorks.TV
{
    /// <summary>
    /// Series dedicated to TV broadcast and associated online delivery.
    /// </summary>
    /// <see cref="http://www.schema.org/TVSeries"/>
    public class TVSeries : CreativeWork
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip. Supersedes actors.
        /// </summary>
        public Person Actor { get; set; }
        /// <summary>
        /// A director of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip. Supersedes directors.
        /// </summary>
        public Person Director { get; set; }
        /// <summary>
        /// An episode of a tv, radio or game media within a series or season. Supersedes episodes.
        /// </summary>
        public TVEpisode Episode { get; set; }
        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        public Thing MusicBy { get; set; }
        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        public int NumberOfEpisodes { get; set; }
        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        public int NumberOfSeasons { get; set; }
        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        public Organization ProductionCompany { get; set; }
        /// <summary>
        /// A season in a media series. Supersedes seasons.
        /// </summary>
        public TVSeason Season { get; set; }
        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        public DateTime StartDate { get; set; }
    }
}
