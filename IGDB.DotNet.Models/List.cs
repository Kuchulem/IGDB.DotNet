using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for List
    ///</summary>
    public class List : IEndpoint
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
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// EntriesCount
        /// </summary>
        public int EntriesCount { get; set; }

        /// <summary>
        /// ListEntries
        /// </summary>
        public IEnumerable<ListEntry> ListEntries { get; set; }

        /// <summary>
        /// ListTags
        /// </summary>
        public IEnumerable<int> ListTags { get; set; }

        /// <summary>
        /// ListedGames
        /// </summary>
        public IEnumerable<Game> ListedGames { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Numbering
        /// </summary>
        public bool Numbering { get; set; }

        /// <summary>
        /// Private
        /// </summary>
        public bool Private { get; set; }

        /// <summary>
        /// SimilarLists
        /// </summary>
        public IEnumerable<List> SimilarLists { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// User
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
