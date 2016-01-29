namespace OakIdeas.Schema.Core.CreativeWorks.Books
{
    /// <summary>
    /// A book.
    /// </summary>
    /// <see cref="http://www.schema.org/Book"/>
    public class Book : CreativeWork
    {
        /// <summary>
        /// The edition of the book.
        /// </summary>
        public string BookEdition { get; set; }
        /// <summary>
        /// The format of the book.
        /// </summary>
        public BookFormatType BookFormat { get; set; }
        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        public Person Illustrator { get; set; }
        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        public int NumberOfPages { get; set; }
    }
}
