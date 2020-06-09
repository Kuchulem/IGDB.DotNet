using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Platform
    ///</summary>
    public class Platform : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Abbreviation
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// AlternativeName
        /// </summary>
        public string AlternativeName { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public PlatformCategoryEnum Category { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Generation
        /// </summary>
        public int Generation { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// PlatformLogo
        /// </summary>
        public PlatformLogo PlatformLogo { get; set; }

        /// <summary>
        /// ProductFamily
        /// </summary>
        public ProductFamily ProductFamily { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Versions
        /// </summary>
        public IEnumerable<PlatformVersion> Versions { get; set; }

        /// <summary>
        /// Websites
        /// </summary>
        public IEnumerable<PlatformWebsite> Websites { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
