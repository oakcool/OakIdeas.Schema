namespace OakIdeas.Schema.Core.CreativeWorks.MediaObjects
{
    /// <summary>
    /// An image file.
    /// </summary>
    /// <see cref="http://www.schema.org/ImageObject"/>
    public class ImageObject : MediaObject
    {
        /// <summary>
        /// The caption for this object.
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// exif data for this object.
        /// </summary>
        public string ExifData { get; set; }
        /// <summary>
        /// Indicates whether this image is representative of the content of the page.
        /// </summary>
        public bool RepresentativeOfPage { get; set; }
        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        public ImageObject Thumbnail { get; set; }
    }
}
