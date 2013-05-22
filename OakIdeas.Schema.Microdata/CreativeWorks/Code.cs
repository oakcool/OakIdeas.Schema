using OakIdeas.Schema.Microdata.CreativeWorks.Software;

namespace OakIdeas.Schema.Microdata.CreativeWorks
{
    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
    /// <see cref="http://www.schema.org/Code"/>
    public class Code : CreativeWork
    {
        /// <summary>
        /// Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex)
        /// </summary>
        public string CodeRepository { get; set; }
        /// <summary>
        /// The computer programming language.
        /// </summary>
        public Thing ProgrammingLanguage { get; set; }
        /// <summary>
        /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0)
        /// </summary>
        public string Runtime { get; set; }
        /// <summary>
        /// Full (compile ready) solution, code snippet, inline code, scripts, template.
        /// </summary>
        public string SampleType { get; set; }
        /// <summary>
        /// Target Operating System / Product to which the code applies. If applies to several versions, just the product name can be used.
        /// </summary>
        public SoftwareApplication TargetProduct { get; set; }
    }
}
