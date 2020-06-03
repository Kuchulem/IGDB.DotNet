using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PlatformVersionReleaseDate
    ///</summary>
    public class PlatformVersionReleaseDate : IEndpoint
    {
        public ulong Id { get; set; }
        public DateFormatChangeDateCategoryEnum Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Date { get; set; }
        public string Human { get; set; }
        public int M { get; set; }
        public PlatformVersion PlatformVersion { get; set; }
        public RegionLanguageEnum Region { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Y { get; set; }
        public string Checksum { get; set; }
    }

}
