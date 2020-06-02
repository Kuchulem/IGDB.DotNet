using IGDB.DotNet.Models.Enums;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameVersionFeature
    ///</summary>
    public class GameVersionFeature
    {
        public ulong Id { get; set; }
        public GameVersionFeatureCategoryEnum Category { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public string Title { get; set; }
        public IEnumerable<GameVersionFeatureValue> Values { get; set; }
        public string Checksum { get; set; }
    }

}
