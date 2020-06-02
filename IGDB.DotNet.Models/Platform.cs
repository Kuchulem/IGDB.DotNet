using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Platform
    ///</summary>
    public class Platform
    {
        public ulong Id { get; set; }
        public string Abbreviation { get; set; }
        public string AlternativeName { get; set; }
        public PlatformCategoryEnum Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Generation { get; set; }
        public string Name { get; set; }
        public PlatformLogo PlatformLogo { get; set; }
        public ProductFamily ProductFamily { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public IEnumerable<PlatformVersion> Versions { get; set; }
        public IEnumerable<PlatformWebsite> Websites { get; set; }
        public string Checksum { get; set; }
    }

}
