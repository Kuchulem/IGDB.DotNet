using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for ReleaseDate
    ///</summary>
    public class ReleaseDate : IEndpoint
    {
        public ulong Id { get; set; }
        public DateFormatChangeDateCategoryEnum Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Date { get; set; }
        public Game Game { get; set; }
        public string Human { get; set; }
        public int M { get; set; }
        public Platform Platform { get; set; }
        public RegionLanguageEnum Region { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Y { get; set; }
        public string Checksum { get; set; }
    }

}
