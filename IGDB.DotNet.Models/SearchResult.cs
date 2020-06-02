using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for SearchResult
    ///</summary>
    public class SearchResult
    {
        public IEnumerable<Search> Searches { get; set; }
    }

}
