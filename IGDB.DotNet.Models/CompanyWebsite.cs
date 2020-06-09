using IGDB.DotNet.Models.Enums;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for CompanyWebsite
    ///</summary>
    public class CompanyWebsite : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public WebsiteCategoryEnum Category { get; set; }

        /// <summary>
        /// Trusted
        /// </summary>
        public bool Trusted { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
