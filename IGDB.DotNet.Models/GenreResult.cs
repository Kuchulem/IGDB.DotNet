using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GenreResult
    ///</summary>
    public class GenreResult
    {

        /// <summary>
        /// Genres
        /// </summary>
        public IEnumerable<Genre> Genres { get; set; }
    }

}
