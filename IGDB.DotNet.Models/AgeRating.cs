using IGDB.DotNet.Models.Enums;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for AgeRating
    ///</summary>
    public class AgeRating
    {
        public ulong Id { get; set; }
        public AgeRatingCategoryEnum Category { get; set; }
        public IEnumerable<AgeRatingContentDescription> ContentDescriptions { get; set; }
        public AgeRatingRatingEnum Rating { get; set; }
        public string RatingCoverUrl { get; set; }
        public string Synopsis { get; set; }
        public string Checksum { get; set; }
    }

}
