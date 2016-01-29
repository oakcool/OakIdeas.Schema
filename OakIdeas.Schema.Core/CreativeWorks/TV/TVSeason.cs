using System;
using System.Collections.Generic;
using OakIdeas.Schema.Core.CreativeWorks.MediaObjects;

namespace OakIdeas.Schema.Core.CreativeWorks.TV
{
    /// <summary>
    /// A TV season.
    /// </summary>
    /// <see cref="http://www.schema.org/TVSeason"/>
    public class TVSeason : CreativeWork
    {
        /// <summary>
        /// The end date and time of the event (in ISO 8601 date format).
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// An episode of a TV series or season.
        /// </summary>
        public TVEpisode Episode { get; set; }
        /// <summary>
        /// The episode of a TV series or season (legacy spelling; see singular form, episode).
        /// </summary>
        public IEnumerable<TVEpisode> Episodes { get; set; }
        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        public int NumberOfEpisodes { get; set; }
        /// <summary>
        /// The TV series to which this episode or season belongs.
        /// </summary>
        public TVSeries PartOfTVSeries { get; set; }
        /// <summary>
        /// The season number.
        /// </summary>
        public int SeasonNumber { get; set; }
        /// <summary>
        /// The start date and time of the event (in ISO 8601 date format).
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// The trailer of the movie or TV series, season, or episode.
        /// </summary>
        public IEnumerable<VideoObject> Trailer { get; set; }
    }
}
