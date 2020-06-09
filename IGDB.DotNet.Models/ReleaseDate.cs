using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for ReleaseDate
    ///</summary>
    public class ReleaseDate : IEndpoint
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
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Human
        /// </summary>
        public string Human { get; set; }

        /// <summary>
        /// M
        /// </summary>
        public int M { get; set; }

        /// <summary>
        /// Platform
        /// </summary>
        public Platform Platform { get; set; }

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
