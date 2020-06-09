using IGDB.DotNet.Models.Enums;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for AgeRating
    ///</summary>
    public class AgeRating : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public AgeRatingCategoryEnum Category { get; set; }

        /// <summary>
        /// ContentDescriptions
        /// </summary>
        public IEnumerable<AgeRatingContentDescription> ContentDescriptions { get; set; }

        /// <summary>
        /// Rating
        /// </summary>
        public AgeRatingRatingEnum Rating { get; set; }

        /// <summary>
        /// RatingCoverUrl
        /// </summary>
        public string RatingCoverUrl { get; set; }

        /// <summary>
        /// Synopsis
        /// </summary>
        public string Synopsis { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
