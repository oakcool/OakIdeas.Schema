using System.Collections.Generic;
using OakIdeas.Schema.Core.CreativeWorks.Music;

namespace OakIdeas.Schema.Core.Organizations.PerformingGroups
{
    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
    /// <see cref="http://www.schema.org/MusicGroup"/>
    public class MusicGroup
    {
        /// <summary>
        /// A music album.
        /// </summary>
        public MusicAlbum Album { get; set; }
        /// <summary>
        /// A collection of music albums (legacy spelling; see singular form, album).
        /// </summary>
        public IEnumerable<MusicAlbum> Albums { get; set; }
        /// <summary>
        /// A member of the music group—for example, John, Paul, George, or Ringo.
        /// </summary>
        public IEnumerable<Person> MusicGroupMembers { get; set; }
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
