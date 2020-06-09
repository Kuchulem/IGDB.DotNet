using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameVersion
    ///</summary>
    public class GameVersion : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Features
        /// </summary>
        public IEnumerable<GameVersionFeature> Features { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Games
        /// </summary>
        public IEnumerable<Game> Games { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
