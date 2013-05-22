namespace OakIdeas.Schema.Microdata
{
    /// <summary>
    /// The most generic type of item.
    /// </summary>
    /// <see cref="http://www.schema.org/Thing"/>
    public class Thing
    {
        public virtual string ItemType
        {
            get { return "http://www.schema.org/" + this.GetType().Name; }
        }

        public string AdditionalType { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
