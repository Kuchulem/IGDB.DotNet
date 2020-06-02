using IGDB.DotNet.Models.Enums;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PageWebsite
    ///</summary>
    public class PageWebsite
    {
        public ulong Id { get; set; }
        public WebsiteCategoryEnum Category { get; set; }
        public bool Trusted { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
