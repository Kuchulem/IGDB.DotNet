namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PersonMugShot
    ///</summary>
    public class PersonMugShot : IEndpoint
    {
        public ulong Id { get; set; }
        public int Height { get; set; }
        public string ImageId { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
        public string Checksum { get; set; }
    }

}
