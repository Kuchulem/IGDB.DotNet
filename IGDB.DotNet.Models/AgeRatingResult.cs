using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for AgeRatingResult
    ///</summary>
    public class AgeRatingResult
    {

        /// <summary>
        /// Ageratings
        /// </summary>
        public IEnumerable<AgeRating> Ageratings { get; set; }
    }

}
