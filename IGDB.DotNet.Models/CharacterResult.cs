using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for CharacterResult
    ///</summary>
    public class CharacterResult
    {

        /// <summary>
        /// Characters
        /// </summary>
        public IEnumerable<Character> Characters { get; set; }
    }

}
