using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Core.Actions.AchieveActions
{
    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// </summary>
    /// <see cref="http://www.schema.org/WinAction"/>
    public class WinAction: AchieveAction
    {
        /// <summary>
        /// A sub property of participant. The loser of the action.
        /// </summary>
        public Person Loser { get; set; }
    }
}
