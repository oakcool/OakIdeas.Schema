namespace OakIdeas.Schema.Core.CreativeWorks.Articles
{
    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
    /// <see cref="http://www.schema.org/APIReference"/>
    public class APIReference : TechArticle
    {
        /// <summary>
        /// Library file name e.g., mscorlib.dll, system.web.dll
        /// </summary>
        public string Assembly { get; set; }
        /// <summary>
        /// Associated product/technology version. e.g., .NET Framework 4.5
        /// </summary>
        public string AssemblyVersion { get; set; }
        /// <summary>
        /// Indicates whether API is managed or unmanaged.
        /// </summary>
        public string ProgrammingModel { get; set; }
        /// <summary>
        /// Type of app development: phone, Metro style, desktop, XBox, etc.
        /// </summary>
        public string TargetPlatform { get; set; }
    }
}
