using System;
using System.Collections.Generic;
using OakIdeas.Schema.Microdata.CreativeWorks.MediaObjects;
using OakIdeas.Schema.Microdata.CreativeWorks.Music;
using OakIdeas.Schema.Microdata.Organizations;

namespace OakIdeas.Schema.Microdata.CreativeWorks.TV
{
    /// <summary>
    /// A television series.
    /// </summary>
    /// <see cref="http://www.schema.org/TVSeries"/>
    public class TVSeries : CreativeWork
    {
        public Person Actor { get; set; }
        public IEnumerable<Person> Actors { get; set; }
        public IEnumerable<Person> Director { get; set; }
        public DateTime EndDate { get; set; }
        public TVEpisode Episode { get; set; }
        public IEnumerable<TVEpisode> Episodes { get; set; }
        public IEnumerable<IMusicWriter> MusicBy { get; set; }
        public int NumberOfEpisodes { get; set; }
        public IEnumerable<Person> Producer { get; set; }
        public IEnumerable<Organization> ProductionCompany { get; set; }
        public TVSeason Season { get; set; }
        public IEnumerable<TVSeason> Seasons { get; set; }
        public DateTime StartDate { get; set; }
        public IEnumerable<VideoObject> Trailers { get; set; }
    }
}
