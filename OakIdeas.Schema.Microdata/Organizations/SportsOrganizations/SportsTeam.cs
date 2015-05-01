namespace OakIdeas.Schema.Microdata.Organizations.SportsOrganizations
{
    /// <summary>
    /// Organization: Sports team.
    /// </summary>
    /// <see cref="http://www.schema.org/SportsTeam"/>
    public class SportsTeam : SportsOrganization
    {
        /// <summary>
        /// A person that acts as performing member of a sports team; a player as opposed to a coach.
        /// </summary>
        public Person Athlete { get; set; }
        /// <summary>
        /// A person that acts in a coaching role for a sports team.
        /// </summary>
        public Person Coach { get; set; }
    }
}
