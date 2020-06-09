using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for SearchResult
    ///</summary>
    public class SearchResult
    {

        /// <summary>
        /// Searches
        /// </summary>
        public IEnumerable<Search> Searches { get; set; }
    }

}
