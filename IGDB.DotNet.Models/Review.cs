using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Review
    ///</summary>
    public class Review : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public ReviewCategoryEnum Category { get; set; }

        /// <summary>
        /// Conclusion
        /// </summary>
        public string Conclusion { get; set; }

        /// <summary>
        /// Content
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Introduction
        /// </summary>
        public string Introduction { get; set; }

        /// <summary>
        /// Likes
        /// </summary>
        public int Likes { get; set; }

        /// <summary>
        /// NegativePoints
        /// </summary>
        public string NegativePoints { get; set; }

        /// <summary>
        /// Platform
        /// </summary>
        public Platform Platform { get; set; }

        /// <summary>
        /// PositivePoints
        /// </summary>
        public string PositivePoints { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

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
        /// UserRating
        /// </summary>
        public Rate UserRating { get; set; }

        /// <summary>
        /// Video
        /// </summary>
        public ReviewVideo Video { get; set; }

        /// <summary>
        /// Views
        /// </summary>
        public int Views { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
