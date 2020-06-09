using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for MultiQueryResult
    ///</summary>
    public class MultiQueryResult
    {

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Results
        /// </summary>
        public IEnumerable<byte> Results { get; set; }

        /// <summary>
        /// Count
        /// </summary>
        public long Count { get; set; }
    }

}
