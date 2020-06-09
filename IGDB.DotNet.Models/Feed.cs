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

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public FeedCategoryEnum Category { get; set; }

        /// <summary>
        /// Content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// FeedLikesCount
        /// </summary>
        public int FeedLikesCount { get; set; }

        /// <summary>
        /// FeedVideo
        /// </summary>
        public GameVideo FeedVideo { get; set; }

        /// <summary>
        /// Games
        /// </summary>
        public IEnumerable<Game> Games { get; set; }

        /// <summary>
        /// Meta
        /// </summary>
        public string Meta { get; set; }

        /// <summary>
        /// PublishedAt
        /// </summary>
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// Pulse
        /// </summary>
        public Pulse Pulse { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Uid
        /// </summary>
        public string Uid { get; set; }

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
        public int User { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
