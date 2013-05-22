namespace OakIdeas.Schema.Microdata.CreativeWorks.MediaObjects
{
    /// <summary>
    /// An audio file.
    /// </summary>
    /// <see cref="http://www.schema.org/AudioObject"/>
    public class AudioObject : MediaObject
    {
        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        public string Transcript { get; set; }
    }
}
