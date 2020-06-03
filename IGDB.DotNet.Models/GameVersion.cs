using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameVersion
    ///</summary>
    public class GameVersion : IEndpoint
    {
        public ulong Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<GameVersionFeature> Features { get; set; }
        public Game Game { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
