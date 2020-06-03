namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Follow
    ///</summary>
    public class Follow : IEndpoint
    {
        public ulong Id { get; set; }
        public Game Game { get; set; }
        public User User { get; set; }
        public string Checksum { get; set; }
    }

}
