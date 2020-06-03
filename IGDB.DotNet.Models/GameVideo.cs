namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameVideo
    ///</summary>
    public class GameVideo : IEndpoint
    {
        public ulong Id { get; set; }
        public Game Game { get; set; }
        public string Name { get; set; }
        public string VideoId { get; set; }
        public string Checksum { get; set; }
    }

}
