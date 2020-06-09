using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Page
    ///</summary>
    public class Page : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Background
        /// </summary>
        public PageBackground Background { get; set; }

        /// <summary>
        /// Battlenet
        /// </summary>
        public string Battlenet { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public PageCategoryEnum Category { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        public ColorColorEnum Color { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        public Company Company { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public int Country { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Feed
        /// </summary>
        public Feed Feed { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Origin
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// PageFollowsCount
        /// </summary>
        public int PageFollowsCount { get; set; }

        /// <summary>
        /// PageLogo
        /// </summary>
        public PageLogo PageLogo { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// SubCategory
        /// </summary>
        public PageSubCategoryEnum SubCategory { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Uplay
        /// </summary>
        public string Uplay { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// User
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Websites
        /// </summary>
        public IEnumerable<PageWebsite> Websites { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
