using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OakIdeas.Schema.Microdata.Organizations;
using OakIdeas.Schema.Microdata.Places;

namespace OakIdeas.Schema.Microdata.Intangibles
{
    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    /// <see cref="http://www.schema.org/JobPosting"/>
    public class JobPosting :Intangible
    {
        /// <summary>
        /// The base salary of the job.
        /// </summary>
        public int BaseSalary { get; set; }
        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        public string Benefits { get; set; }
        /// <summary>
        /// Publication date for the job posting.
        /// </summary>
        public DateTime DatePosted { get; set; }
        /// <summary>
        /// Educational background needed for the position.
        /// </summary>
        public string EducationRequirements { get; set; }
        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        public string EmploymentType { get; set; }
        /// <summary>
        /// Description of skills and experience needed for the position.
        /// </summary>
        public string ExperienceRequirements { get; set; }
        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        public Organization HiringOrganization { get; set; }
        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        public string Incentives { get; set; }
        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        public string Industry { get; set; }
        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        public Place JobLocation { get; set; }
        /// <summary>
        /// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
        /// </summary>
        public string OccupationalCategory { get; set; }
        /// <summary>
        /// Specific qualifications required for this role.
        /// </summary>
        public string Qualifications { get; set; }
        /// <summary>
        /// Responsibilities associated with this role.
        /// </summary>
        public string Responsabilities { get; set; }
        /// <summary>
        /// The currency (coded using ISO 4217, http://en.wikipedia.org/wiki/ISO_4217 used for the main salary information in this job posting.
        /// </summary>
        public string SalaryCurrency { get; set; }
        /// <summary>
        /// Skills required to fulfill this role.
        /// </summary>
        public string Skills { get; set; }
        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        public string SpecialCommitments { get; set; }
        /// <summary>
        /// The title of the job.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        public string WorkHours { get; set; }
    }
}
