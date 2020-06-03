using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Feed
    ///</summary>
    public class Feed : IEndpoint
    {
        public ulong Id { get; set; }
        public FeedCategoryEnum Category { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int FeedLikesCount { get; set; }
        public GameVideo FeedVideo { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public string Meta { get; set; }
        public DateTime PublishedAt { get; set; }
        public Pulse Pulse { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Uid { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public int User { get; set; }
        public string Checksum { get; set; }
    }

}
