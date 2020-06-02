using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for FeedFollow
    ///</summary>
    public class FeedFollow
    {
        public ulong Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public FeedCategoryEnum Feed { get; set; }
        public DateTime PublishedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User User { get; set; }
        public string Checksum { get; set; }
    }

}
