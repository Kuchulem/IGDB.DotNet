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
        public ulong Id { get; set; }
        public PageBackground Background { get; set; }
        public string Battlenet { get; set; }
        public PageCategoryEnum Category { get; set; }
        public ColorColorEnum Color { get; set; }
        public Company Company { get; set; }
        public int Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public Feed Feed { get; set; }
        public Game Game { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public int PageFollowsCount { get; set; }
        public PageLogo PageLogo { get; set; }
        public string Slug { get; set; }
        public PageSubCategoryEnum SubCategory { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Uplay { get; set; }
        public string Url { get; set; }
        public User User { get; set; }
        public IEnumerable<PageWebsite> Websites { get; set; }
        public string Checksum { get; set; }
    }

}
