using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Schema.Core.CreativeWorks
{
    /// <summary>
    /// A software application.
    /// </summary>
    /// /// <see cref="http://www.schema.org/SoftwareApplication"/>
    public class SoftwareApplication : Thing
    {
        /// <summary>
        /// Type of software application, e.g. "Game, Multimedia".
        /// </summary>
        public string ApplicationCategory { get; set; }
        /// <summary>
        /// Subcategory of the application, e.g. "Arcade Game".
        /// </summary>
        public string ApplicationSubCategory { get; set; }
        /// <summary>
        /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
        /// </summary>
        public string ApplicationSuite { get; set; }
        /// <summary>
        /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        public string CountriesNotSupported { get; set; }
        /// <summary>
        /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        public string CountriesSupported { get; set; }
        /// <summary>
        /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
        /// </summary>
        public string Device { get; set; }
        //TODO: Should it be an URI?
        /// <summary>
        /// If the file can be downloaded, URL to download the binary.
        /// </summary>
        public string DownloadUrl { get; set; }
        /// <summary>
        /// Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        public string FeatureList { get; set; }
        /// <summary>
        /// MIME format of the binary (e.g. application/zip).
        /// </summary>
        public string FileFormat { get; set; }
        /// <summary>
        /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
        /// </summary>
        public int FileSize { get; set; }
        /// <summary>
        /// URL at which the app may be installed, if different from the URL of the item.
        /// </summary>
        public string InstallUrl { get; set; }
        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        public string MemoryRequirements { get; set; }
        /// <summary>
        /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
        /// </summary>
        public string OperatingSystem { get; set; }
        /// <summary>
        /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
        /// </summary>
        public string Permissions { get; set; }
        /// <summary>
        /// Processor architecture required to run the application (e.g. IA64).
        /// </summary>
        public string ProcessorRequirements { get; set; }
        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        public string ReleaseNotes { get; set; }
        /// <summary>
        /// Component dependency requirements for application. 
        /// This includes runtime environments and shared libraries that are not included in the application distribution package,
        /// but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        public string Requirements { get; set; }
        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        public string Screenshot { get; set; }
        /// <summary>
        /// Additional content for a software application.
        /// </summary>
        public SoftwareApplication SoftwareAddOn { get; set; }
        /// <summary>
        /// Software application help.
        /// </summary>
        public CreativeWork SoftwareHelp { get; set; }
        /// <summary>
        /// Version of the software instance.
        /// </summary>
        public string SoftwareVersion { get; set; }
        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        public string StorageRequirements { get; set; }

    }
}
