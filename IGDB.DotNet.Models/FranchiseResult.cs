using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for FranchiseResult
    ///</summary>
    public class FranchiseResult
    {

        /// <summary>
        /// Franchises
        /// </summary>
        public IEnumerable<Franchise> Franchises { get; set; }
    }

}
