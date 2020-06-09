using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Achievement
    ///</summary>
    public class Achievement : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// AchievementIcon
        /// </summary>
        public AchievementIcon AchievementIcon { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public AchievementCategoryEnum Category { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ExternalId
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        public RegionLanguageEnum Language { get; set; }

        /// <summary>
        /// LockedAchievementIcon
        /// </summary>
        public AchievementIcon LockedAchievementIcon { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Owners
        /// </summary>
        public int Owners { get; set; }

        /// <summary>
        /// OwnersPercentage
        /// </summary>
        public double OwnersPercentage { get; set; }

        /// <summary>
        /// Rank
        /// </summary>
        public AchievementRankEnum Rank { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        public IEnumerable<int> Tags { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
