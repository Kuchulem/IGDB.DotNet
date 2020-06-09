namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for ListEntry
    ///</summary>
    public class ListEntry : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// List
        /// </summary>
        public List List { get; set; }

        /// <summary>
        /// Platform
        /// </summary>
        public Platform Platform { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Private
        /// </summary>
        public bool Private { get; set; }

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
