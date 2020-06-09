namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for MultiplayerMode
    ///</summary>
    public class MultiplayerMode : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Campaigncoop
        /// </summary>
        public bool Campaigncoop { get; set; }

        /// <summary>
        /// Dropin
        /// </summary>
        public bool Dropin { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Lancoop
        /// </summary>
        public bool Lancoop { get; set; }

        /// <summary>
        /// Offlinecoop
        /// </summary>
        public bool Offlinecoop { get; set; }

        /// <summary>
        /// Offlinecoopmax
        /// </summary>
        public int Offlinecoopmax { get; set; }

        /// <summary>
        /// Offlinemax
        /// </summary>
        public int Offlinemax { get; set; }

        /// <summary>
        /// Onlinecoop
        /// </summary>
        public bool Onlinecoop { get; set; }

        /// <summary>
        /// Onlinecoopmax
        /// </summary>
        public int Onlinecoopmax { get; set; }

        /// <summary>
        /// Onlinemax
        /// </summary>
        public int Onlinemax { get; set; }

        /// <summary>
        /// Platform
        /// </summary>
        public Platform Platform { get; set; }

        /// <summary>
        /// Splitscreen
        /// </summary>
        public bool Splitscreen { get; set; }

        /// <summary>
        /// Splitscreenonline
        /// </summary>
        public bool Splitscreenonline { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
