using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for FeedResult
    ///</summary>
    public class FeedResult
    {

        /// <summary>
        /// Feeds
        /// </summary>
        public IEnumerable<Feed> Feeds { get; set; }
    }

}
