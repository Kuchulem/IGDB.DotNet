namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PlatformVersionCompany
    ///</summary>
    public class PlatformVersionCompany : IEndpoint
    {
        public ulong Id { get; set; }
        public string Comment { get; set; }
        public Company Company { get; set; }
        public bool Developer { get; set; }
        public bool Manufacturer { get; set; }
        public string Checksum { get; set; }
    }

}
