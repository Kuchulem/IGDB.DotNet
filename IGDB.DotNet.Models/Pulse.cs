using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Pulse
    ///</summary>
    public class Pulse
    {
        public ulong Id { get; set; }
        public string Author { get; set; }
        public int Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Ignored { get; set; }
        public string Image { get; set; }
        public DateTime PublishedAt { get; set; }
        public PulseImage PulseImage { get; set; }
        public PulseSource PulseSource { get; set; }
        public string Summary { get; set; }
        public IEnumerable<int> Tags { get; set; }
        public string Title { get; set; }
        public string Uid { get; set; }
        public DateTime UpdatedAt { get; set; }
        public IEnumerable<string> Videos { get; set; }
        public PulseUrl Website { get; set; }
        public string Checksum { get; set; }
    }

}
