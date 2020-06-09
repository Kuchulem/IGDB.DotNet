using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for CollectionResult
    ///</summary>
    public class CollectionResult
    {

        /// <summary>
        /// Collections
        /// </summary>
        public IEnumerable<Collection> Collections { get; set; }
    }

}
