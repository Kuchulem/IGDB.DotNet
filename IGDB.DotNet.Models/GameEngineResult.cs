using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for GameEngineResult
    ///</summary>
    public class GameEngineResult
    {

        /// <summary>
        /// Gameengines
        /// </summary>
        public IEnumerable<GameEngine> Gameengines { get; set; }
    }

}
