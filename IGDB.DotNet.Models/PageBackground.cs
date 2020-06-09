namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PageBackground
    ///</summary>
    public class PageBackground : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// AlphaChannel
        /// </summary>
        public bool AlphaChannel { get; set; }

        /// <summary>
        /// Animated
        /// </summary>
        public bool Animated { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// ImageId
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
