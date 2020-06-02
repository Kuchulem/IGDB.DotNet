using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for ExternalGame
    ///</summary>
    public class ExternalGame
    {
        public ulong Id { get; set; }
        public ExternalGameCategoryEnum Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public Game Game { get; set; }
        public string Name { get; set; }
        public string Uid { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public int Year { get; set; }
        public ExternalGameMediaEnum Media { get; set; }
        public Platform Platform { get; set; }
        public IEnumerable<int> Countries { get; set; }
        public string Checksum { get; set; }
    }

}
