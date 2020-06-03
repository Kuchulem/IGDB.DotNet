using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameMode
    ///</summary>
    public class GameMode : IEndpoint
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
