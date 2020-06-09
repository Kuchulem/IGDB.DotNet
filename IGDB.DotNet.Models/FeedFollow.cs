using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for FeedFollow
    ///</summary>
    public class FeedFollow : IEndpoint
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
        /// Feed
        /// </summary>
        public FeedCategoryEnum Feed { get; set; }

        /// <summary>
        /// PublishedAt
        /// </summary>
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

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
