using System;
using System.Collections.Generic;
using System.Text;

namespace IGDB.DotNet.Client.Configuration
{
    /// <summary>
    /// Configuration interface for IgdbClient
    /// </summary>
    public interface IIgdbConfiguration
    {
        /// <summary>
        /// Url to IGDB
        /// </summary>
        Uri IgdbUrl { get; }

        /// <summary>
        /// IGDB user token
        /// </summary>
        string UserToken { get; }
    }
}
