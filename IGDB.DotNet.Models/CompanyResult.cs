using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for CompanyResult
    ///</summary>
    public class CompanyResult
    {

        /// <summary>
        /// Companies
        /// </summary>
        public IEnumerable<Company> Companies { get; set; }
    }

}
