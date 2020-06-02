using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Genre
    ///</summary>
    public class Genre
    {
        public ulong Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
