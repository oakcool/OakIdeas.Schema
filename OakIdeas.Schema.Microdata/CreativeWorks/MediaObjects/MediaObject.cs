using System;
using System.Collections.Generic;
using OakIdeas.Schema.Microdata.CreativeWorks.Articles;
using OakIdeas.Schema.Microdata.Intangibles;

namespace OakIdeas.Schema.Microdata.CreativeWorks.MediaObjects
{
    /// <summary>
    /// An image, video, or audio object embedded in a web page. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// </summary>
    /// <see cref="http://www.schema.org/MediaObject"/>
    public class MediaObject : CreativeWork
    {
        /// <summary>
        /// A NewsArticle associated with the Media Object.
        /// </summary>
        public NewsArticle AssociatedArticle { get; set; }
        /// <summary>
        /// The bitrate of the media object.
        /// </summary>
        public string Bitrate { get; set; }
        /// <summary>
        /// File size in (mega/kilo) bytes.
        /// </summary>
        public string ContentSize { get; set; }
        /// <summary>
        /// Actual bytes of the media object, for example the image file or video file. (previous spelling: contentURL)
        /// </summary>
        public string ContentUrl { get; set; }
        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.
        /// </summary>
        public Duration Duration { get; set; }
        /// <summary>
        /// A URL pointing to a player for a specific video. In general, this is the information in the src element of an embed tag and should not be the same as the content of the loc tag. (previous spelling: embedURL)
        /// </summary>
        public string EmbedUrl { get; set; }
        /// <summary>
        /// The creative work encoded by this media object
        /// </summary>
        public CreativeWork EncodesCreativeWork { get; set; }
        /// <summary>
        /// mp3, mpeg4, etc.
        /// </summary>
        public string EncodingFormat { get; set; }
        /// <summary>
        /// Date the content expires and is no longer useful or available. Useful for videos.
        /// </summary>
        public DateTime Expires { get; set; }
        /// <summary>
        /// The height of the item.
        /// </summary>
        public IQuantitativeValue Height { get; set; }
        /// <summary>
        /// Player type required—for example, Flash or Silverlight.
        /// </summary>
        public string PlayerType { get; set; }
        /// <summary>
        /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in ISO 3166 format.
        /// </summary>
        public IEnumerable<Place> RegionsAllowed { get; set; }
        /// <summary>
        /// Indicates if use of the media require a subscription (either paid or free). Allowed values are true or false (note that an earlier version had 'yes', 'no').
        /// </summary>
        public bool RequiresSubscription { get; set; }
        /// <summary>
        /// Date when this media object was uploaded to this site.
        /// </summary>
        public DateTime UploadDate { get; set; }
        /// <summary>
        /// The width of the item.
        /// </summary>
        public IQuantitativeValue Width { get; set; }

    }
}
