namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PersonMugShot
    ///</summary>
    public class PersonMugShot : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

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
