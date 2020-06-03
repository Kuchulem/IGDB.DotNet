using IGDB.DotNet.Models.Enums;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PersonWebsite
    ///</summary>
    public class PersonWebsite : IEndpoint
    {
        public ulong Id { get; set; }
        public WebsiteCategoryEnum Category { get; set; }
        public bool Trusted { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
