namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PulseUrl
    ///</summary>
    public class PulseUrl
    {
        public ulong Id { get; set; }
        public bool Trusted { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
