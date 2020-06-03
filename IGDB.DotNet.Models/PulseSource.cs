namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PulseSource
    ///</summary>
    public class PulseSource : IEndpoint
    {
        public ulong Id { get; set; }
        public Game Game { get; set; }
        public string Name { get; set; }
        public Page Page { get; set; }
        public string Checksum { get; set; }
    }

}
