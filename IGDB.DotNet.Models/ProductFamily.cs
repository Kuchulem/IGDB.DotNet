namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for ProductFamily
    ///</summary>
    public class ProductFamily : IEndpoint
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Checksum { get; set; }
    }

}
