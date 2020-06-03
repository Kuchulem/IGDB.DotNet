using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Collection
    ///</summary>
    public class Collection : IEndpoint
    {
        public ulong Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
