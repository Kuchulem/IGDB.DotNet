using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for MultiQueryResultArray
    ///</summary>
    public class MultiQueryResultArray
    {

        /// <summary>
        /// Result
        /// </summary>
        public IEnumerable<MultiQueryResult> Result { get; set; }
    }

}
