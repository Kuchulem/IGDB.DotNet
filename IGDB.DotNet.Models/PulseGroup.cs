using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PulseGroup
    ///</summary>
    public class PulseGroup : IEndpoint
    {
        public ulong Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Game Game { get; set; }
        public string Name { get; set; }
        public DateTime PublishedAt { get; set; }
        public IEnumerable<Pulse> Pulses { get; set; }
        public IEnumerable<int> Tags { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Checksum { get; set; }
    }

}
