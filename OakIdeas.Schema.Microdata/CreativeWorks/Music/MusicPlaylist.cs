using System.Collections.Generic;

namespace OakIdeas.Schema.Microdata.CreativeWorks.Music
{
    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
    /// <see cref="http://www.schema.org/MusicPlaylist"/>
    public class MusicPlaylist : CreativeWork
    {
        /// <summary>
        /// The number of tracks in this album or playlist.
        /// </summary>
        public int NumTracks { get; set; }
        /// <summary>
        /// A music recording (track)—usually a single song.
        /// </summary>
        public MusicRecording Track { get; set; }
        /// <summary>
        /// A music recording (track)—usually a single song (legacy spelling; see singular form, track).
        /// </summary>
        public IEnumerable<MusicRecording> Tracks { get; set; }
    }
}
