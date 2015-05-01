using System;
using OakIdeas.Schema.Microdata.CreativeWorks;

namespace OakIdeas.Schema.Microdata.Events.UserInteractions
{
    /// <summary>
    /// The UserInteraction event in which a user comments on an item.
    /// </summary>
    /// <see cref="http://www.schema.org/UserComments"/>
    public class UserComments : UserInteraction
    {
        /// <summary>
        /// The text of the UserComment.
        /// </summary>
        public string CommentText { get; set; }
        /// <summary>
        /// The time at which the UserComment was made.
        /// </summary>
        public DateTime CommentTime { get; set; }
        /// <summary>
        /// The creator/author of this CreativeWork or UserComments. This is the same as the Author property for CreativeWork.
        /// </summary>
        public Thing Creator { get; set; }
        /// <summary>
        /// Specifies the CreativeWork associated with the UserComment.
        /// </summary>
        public CreativeWork Discusses { get; set; }
        /// <summary>
        /// The URL at which a reply may be posted to the specified UserComment.
        /// </summary>
        public string ReplyToUrl { get; set; }
    }
}
