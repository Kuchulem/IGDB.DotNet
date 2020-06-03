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
        public ulong Id { get; set; }
        public AchievementIcon AchievementIcon { get; set; }
        public AchievementCategoryEnum Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public string ExternalId { get; set; }
        public Game Game { get; set; }
        public RegionLanguageEnum Language { get; set; }
        public AchievementIcon LockedAchievementIcon { get; set; }
        public string Name { get; set; }
        public int Owners { get; set; }
        public double OwnersPercentage { get; set; }
        public AchievementRankEnum Rank { get; set; }
        public string Slug { get; set; }
        public IEnumerable<int> Tags { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Checksum { get; set; }
    }

}
