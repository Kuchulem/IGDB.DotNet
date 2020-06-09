using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PlatformVersion
    ///</summary>
    public class PlatformVersion : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Companies
        /// </summary>
        public IEnumerable<PlatformVersionCompany> Companies { get; set; }

        /// <summary>
        /// Connectivity
        /// </summary>
        public string Connectivity { get; set; }

        /// <summary>
        /// Cpu
        /// </summary>
        public string Cpu { get; set; }

        /// <summary>
        /// Graphics
        /// </summary>
        public string Graphics { get; set; }

        /// <summary>
        /// MainManufacturer
        /// </summary>
        public PlatformVersionCompany MainManufacturer { get; set; }

        /// <summary>
        /// Media
        /// </summary>
        public string Media { get; set; }

        /// <summary>
        /// Memory
        /// </summary>
        public string Memory { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Online
        /// </summary>
        public string Online { get; set; }

        /// <summary>
        /// Os
        /// </summary>
        public string Os { get; set; }

        /// <summary>
        /// Output
        /// </summary>
        public string Output { get; set; }

        /// <summary>
        /// PlatformLogo
        /// </summary>
        public PlatformLogo PlatformLogo { get; set; }

        /// <summary>
        /// PlatformVersionReleaseDates
        /// </summary>
        public IEnumerable<PlatformVersionReleaseDate> PlatformVersionReleaseDates { get; set; }

        /// <summary>
        /// Resolutions
        /// </summary>
        public string Resolutions { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Sound
        /// </summary>
        public string Sound { get; set; }

        /// <summary>
        /// Storage
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
