using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for MultiQueryResult
    ///</summary>
    public class MultiQueryResult
    {
        public string Name { get; set; }
        public IEnumerable<byte> Results { get; set; }
        public long Count { get; set; }
    }

}
