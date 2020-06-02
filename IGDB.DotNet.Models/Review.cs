using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Review
    ///</summary>
    public class Review
    {
        public ulong Id { get; set; }
        public ReviewCategoryEnum Category { get; set; }
        public string Conclusion { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public Game Game { get; set; }
        public string Introduction { get; set; }
        public int Likes { get; set; }
        public string NegativePoints { get; set; }
        public Platform Platform { get; set; }
        public string PositivePoints { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public User User { get; set; }
        public Rate UserRating { get; set; }
        public ReviewVideo Video { get; set; }
        public int Views { get; set; }
        public string Checksum { get; set; }
    }

}
