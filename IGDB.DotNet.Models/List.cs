using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for List
    ///</summary>
    public class List
    {
        public ulong Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public int EntriesCount { get; set; }
        public IEnumerable<ListEntry> ListEntries { get; set; }
        public IEnumerable<int> ListTags { get; set; }
        public IEnumerable<Game> ListedGames { get; set; }
        public string Name { get; set; }
        public bool Numbering { get; set; }
        public bool Private { get; set; }
        public IEnumerable<List> SimilarLists { get; set; }
        public string Slug { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public User User { get; set; }
        public string Checksum { get; set; }
    }

}
