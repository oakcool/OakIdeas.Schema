using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Microdata.Organizations;
using OakIdeas.Schema.Microdata.Organizations.PerformingGroups;

namespace OakIdeas.Schema.Microdata.CreativeWorks.Music
{
    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    /// <see cref="http://www.schema.org/MusicAlbum"/>
    public class MusicAlbum: MusicPlaylist
    {
        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        public MusicGroup ByArtist { get; set; }
    }
}
