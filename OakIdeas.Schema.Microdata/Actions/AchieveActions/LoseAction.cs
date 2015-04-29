using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Microdata.Actions.AchieveActions
{
    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// </summary>
    /// <see cref="http://www.schema.org/LoseAction"/>
    public class LoseAction : AchieveAction
    {
        /// <summary>
        /// A sub property of participant. The winner of the action.
        /// </summary>
        public Person Winner { get; set; }
    }
}
