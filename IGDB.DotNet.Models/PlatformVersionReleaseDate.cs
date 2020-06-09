using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PlatformVersionReleaseDate
    ///</summary>
    public class PlatformVersionReleaseDate : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public DateFormatChangeDateCategoryEnum Category { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Human
        /// </summary>
        public string Human { get; set; }

        /// <summary>
        /// M
        /// </summary>
        public int M { get; set; }

        /// <summary>
        /// PlatformVersion
        /// </summary>
        public PlatformVersion PlatformVersion { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        public RegionLanguageEnum Region { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Y
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
