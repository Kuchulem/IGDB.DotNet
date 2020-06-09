using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PulseGroup
    ///</summary>
    public class PulseGroup : IEndpoint
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
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// PublishedAt
        /// </summary>
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// Pulses
        /// </summary>
        public IEnumerable<Pulse> Pulses { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        public IEnumerable<int> Tags { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
