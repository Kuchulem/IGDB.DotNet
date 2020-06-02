using IGDB.DotNet.Models.Enums;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameVersionFeatureValue
    ///</summary>
    public class GameVersionFeatureValue
    {
        public ulong Id { get; set; }
        public Game Game { get; set; }
        public GameVersionFeature GameFeature { get; set; }
        public GameVersionFeatureValueIncludedFeatureEnum IncludedFeature { get; set; }
        public string Note { get; set; }
        public string Checksum { get; set; }
    }

}
