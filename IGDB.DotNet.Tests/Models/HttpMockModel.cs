using System;
using System.Collections.Generic;
using System.Text;

namespace IGDB.DotNet.Tests.Models
{
    class HttpMockModel
    {
        public string Url { get; set; }
        public string UserKeyHeader { get; set; }
        public int UserKeyHeaderCount { get; set; }
        public string RequestBody { get; set; }
    }
}
