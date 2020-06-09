namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PlatformVersionCompany
    ///</summary>
    public class PlatformVersionCompany : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        public Company Company { get; set; }

        /// <summary>
        /// Developer
        /// </summary>
        public bool Developer { get; set; }

        /// <summary>
        /// Manufacturer
        /// </summary>
        public bool Manufacturer { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
