using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for RateResult
    ///</summary>
    public class RateResult
    {

        /// <summary>
        /// Rates
        /// </summary>
        public IEnumerable<Rate> Rates { get; set; }
    }

}
