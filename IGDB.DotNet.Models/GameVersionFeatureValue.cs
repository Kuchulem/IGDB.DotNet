using IGDB.DotNet.Models.Enums;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameVersionFeatureValue
    ///</summary>
    public class GameVersionFeatureValue : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// GameFeature
        /// </summary>
        public GameVersionFeature GameFeature { get; set; }

        /// <summary>
        /// IncludedFeature
        /// </summary>
        public GameVersionFeatureValueIncludedFeatureEnum IncludedFeature { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
