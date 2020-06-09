using IGDB.DotNet.Models.Enums;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for AgeRatingContentDescription
    ///</summary>
    public class AgeRatingContentDescription : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public AgeRatingRatingEnum Category { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
