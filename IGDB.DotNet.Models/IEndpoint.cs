using System;
using System.Collections.Generic;
using System.Text;

namespace IGDB.DotNet.Models
{
    /// <summary>
    /// IEndpoint interface : describes a IGDB endpoint
    /// </summary>
    public interface IEndpoint
    {
        /// <summary>
        /// Id
        /// </summary>
        ulong Id { get; set; }
    }
}
