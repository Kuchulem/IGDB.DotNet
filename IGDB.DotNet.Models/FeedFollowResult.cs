using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for FeedFollowResult
    ///</summary>
    public class FeedFollowResult
    {

        /// <summary>
        /// Feedfollows
        /// </summary>
        public IEnumerable<FeedFollow> Feedfollows { get; set; }
    }

}
