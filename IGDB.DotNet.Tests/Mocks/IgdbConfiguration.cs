using IGDB.DotNet.Client.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace IGDB.DotNet.Tests.Mocks
{
    class IgdbConfiguration : IIgdbConfiguration
    {
        public Uri IgbdUrl => new Uri("https://mocked.url.org");

        public string UserToken => "mocked-user-token";
    }
}
