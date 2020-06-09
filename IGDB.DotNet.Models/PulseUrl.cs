namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PulseUrl
    ///</summary>
    public class PulseUrl : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

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
