namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for TimeToBeat
    ///</summary>
    public class TimeToBeat : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Completely
        /// </summary>
        public int Completely { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Hastly
        /// </summary>
        public int Hastly { get; set; }

        /// <summary>
        /// Normally
        /// </summary>
        public int Normally { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
