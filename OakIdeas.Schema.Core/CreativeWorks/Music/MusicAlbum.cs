using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Core.Organizations;
using OakIdeas.Schema.Core.Organizations.PerformingGroups;

namespace OakIdeas.Schema.Core.CreativeWorks.Music
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
