using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PersonResult
    ///</summary>
    public class PersonResult
    {

        /// <summary>
        /// People
        /// </summary>
        public IEnumerable<Person> People { get; set; }
    }

}
