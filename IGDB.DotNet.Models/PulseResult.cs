using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for PulseResult
    ///</summary>
    public class PulseResult
    {

        /// <summary>
        /// Pulses
        /// </summary>
        public IEnumerable<Pulse> Pulses { get; set; }
    }

}
