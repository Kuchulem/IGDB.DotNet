namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for ReviewVideo
    ///</summary>
    public class ReviewVideo
    {
        public ulong Id { get; set; }
        public bool Trusted { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
