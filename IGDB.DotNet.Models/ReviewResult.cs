using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for ReviewResult
    ///</summary>
    public class ReviewResult
    {

        /// <summary>
        /// Reviews
        /// </summary>
        public IEnumerable<Review> Reviews { get; set; }
    }

}
