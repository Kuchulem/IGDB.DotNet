using IGDB.DotNet.Models.Enums;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for AgeRatingContentDescription
    ///</summary>
    public class AgeRatingContentDescription
    {
        public ulong Id { get; set; }
        public AgeRatingRatingEnum Category { get; set; }
        public string Description { get; set; }
        public string Checksum { get; set; }
    }

}
