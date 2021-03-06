﻿using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for FollowResult
    ///</summary>
    public class FollowResult
    {

        /// <summary>
        /// Follows
        /// </summary>
        public IEnumerable<Follow> Follows { get; set; }
    }

}
