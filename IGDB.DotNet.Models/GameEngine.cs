using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameEngine
    ///</summary>
    public class GameEngine
    {
        public ulong Id { get; set; }
        public IEnumerable<Company> Companies { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public GameEngineLogo Logo { get; set; }
        public string Name { get; set; }
        public IEnumerable<Platform> Platforms { get; set; }
        public string Slug { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
