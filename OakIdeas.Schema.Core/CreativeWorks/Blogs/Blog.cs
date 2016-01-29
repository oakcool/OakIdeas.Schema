using System.Collections.Generic;

namespace OakIdeas.Schema.Core.CreativeWorks.Blogs
{
    /// <summary>
    /// A blog
    /// </summary>
    /// <see cref="http://www.schema.org/Blog"/>
    public class Blog : CreativeWork
    {
        /// <summary>
        /// A posting that is part of this blog.
        /// </summary>
        public BlogPosting BlogPost { get; set; }
        /// <summary>
        /// The postings that are part of this blog (legacy spelling; see singular form, blogPost).
        /// </summary>
        public IEnumerable<BlogPosting> BlogPostings { get; set; }
    }
}
