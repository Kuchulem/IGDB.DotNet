using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameVersionResult
    ///</summary>
    public class GameVersionResult
    {

        /// <summary>
        /// Gameversions
        /// </summary>
        public IEnumerable<GameVersion> Gameversions { get; set; }
    }

}
