using OakIdeas.Schema.Core.Organizations;

namespace OakIdeas.Schema.Core.CreativeWorks.MediaObjects
{
    /// <summary>
    /// A video file.
    /// </summary>
    /// <see cref="http://www.schema.org/VideoObject"/>
    public class VideoObject : MediaObject
    {
        /// <summary>
        /// The caption for this object.
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// The production company or studio that made the movie, TV series, season, or episode, or video.
        /// </summary>
        public Organization ProductionCompany { get; set; }
        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        public ImageObject Thumbnail { get; set; }
        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        public string Transcript { get; set; }
        /// <summary>
        /// The frame size of the video.
        /// </summary>
        public string VideoFrameSize { get; set; }
        /// <summary>
        /// The quality of the video.
        /// </summary>
        public string VideoQuality { get; set; }

    }
}
