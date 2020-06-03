using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PlatformVersion
    ///</summary>
    public class PlatformVersion : IEndpoint
    {
        public ulong Id { get; set; }
        public IEnumerable<PlatformVersionCompany> Companies { get; set; }
        public string Connectivity { get; set; }
        public string Cpu { get; set; }
        public string Graphics { get; set; }
        public PlatformVersionCompany MainManufacturer { get; set; }
        public string Media { get; set; }
        public string Memory { get; set; }
        public string Name { get; set; }
        public string Online { get; set; }
        public string Os { get; set; }
        public string Output { get; set; }
        public PlatformLogo PlatformLogo { get; set; }
        public IEnumerable<PlatformVersionReleaseDate> PlatformVersionReleaseDates { get; set; }
        public string Resolutions { get; set; }
        public string Slug { get; set; }
        public string Sound { get; set; }
        public string Storage { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
