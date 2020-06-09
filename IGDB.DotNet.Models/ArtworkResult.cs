using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for ArtworkResult
    ///</summary>
    public class ArtworkResult
    {

        /// <summary>
        /// Artworks
        /// </summary>
        public IEnumerable<Artwork> Artworks { get; set; }
    }

}
