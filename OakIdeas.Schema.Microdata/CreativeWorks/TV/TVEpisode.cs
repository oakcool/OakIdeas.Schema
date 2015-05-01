using System.Collections.Generic;
using OakIdeas.Schema.Microdata.CreativeWorks.MediaObjects;
using OakIdeas.Schema.Microdata.CreativeWorks.Music;
using OakIdeas.Schema.Microdata.Organizations;

namespace OakIdeas.Schema.Microdata.CreativeWorks.TV
{
    /// <summary>
    /// An episode of a TV series or season.
    /// </summary>
    /// <see cref="http://www.schema.org/TVEpisode"/>
    public class TVEpisode : CreativeWork
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip. Supersedes actors.
        /// </summary>
        public Person Actor { get; set; }
        /// <summary>
        /// The director of the movie, TV episode, or series.
        /// </summary>
        public Person Director { get; set; }
        /// <summary>
        /// The episode number.
        /// </summary>
        public int EpsiodeNumber { get; set; }
        /// <summary>
        /// The composer of the movie or TV soundtrack.
        /// </summary>
        public Thing MusicBy { get; set; }
        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        public TVSeason PartOfSeason { get; set; }
        /// <summary>
        /// The TV series to which this episode or season belongs.
        /// </summary>
        public TVSeries PartOfTVSeries { get; set; }
        /// <summary>
        /// The producer of the movie, TV series, season, or episode, or video.
        /// </summary>
        public Person Producer { get; set; }
        /// <summary>
        /// The production company or studio that made the movie, TV series, season, or episode, or video.
        /// </summary>
        public Organization ProductionCompany { get; set; }
        /// <summary>
        /// The trailer of the movie or TV series, season, or episode.
        /// </summary>
        public VideoObject Trailer { get; set; }
    }
}
