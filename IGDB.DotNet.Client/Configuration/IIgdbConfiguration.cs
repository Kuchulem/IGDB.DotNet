using System;
using System.Collections.Generic;
using System.Text;

namespace IGDB.DotNet.Client.Configuration
{
    public interface IIgdbConfiguration
    {
        Uri IgbdUrl { get; }
        string UserToken { get; }
    }
}
