namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Rate
    ///</summary>
    public class Rate : IEndpoint
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
        /// Private
        /// </summary>
        public bool Private { get; set; }

        /// <summary>
        /// Rating
        /// </summary>
        public double Rating { get; set; }

        /// <summary>
        /// User
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
