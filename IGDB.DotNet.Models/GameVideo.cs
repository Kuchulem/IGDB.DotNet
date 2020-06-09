namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameVideo
    ///</summary>
    public class GameVideo : IEndpoint
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
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// VideoId
        /// </summary>
        public string VideoId { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
