using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for CoverResult
    ///</summary>
    public class CoverResult
    {

        /// <summary>
        /// Covers
        /// </summary>
        public IEnumerable<Cover> Covers { get; set; }
    }

}
