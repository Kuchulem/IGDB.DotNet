using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameResult
    ///</summary>
    public class GameResult
    {

        /// <summary>
        /// Games
        /// </summary>
        public IEnumerable<Game> Games { get; set; }
    }

}
