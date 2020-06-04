using IGDB.DotNet.Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace IGDB.DotNet.Tests.Mocks
{
    class HttpMessageHandlerMock : HttpMessageHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return new HttpResponseMessage
            {
                Content = new StringContent(JsonSerializer.Serialize(new[] {new HttpMockModel
                {
                    Url = request.RequestUri.AbsoluteUri,
                    UserKeyHeader = request.Headers.GetValues("user-key").FirstOrDefault(),
                    UserKeyHeaderCount = request.Headers.GetValues("user-key").Count(),
                    RequestBody = await request.Content.ReadAsStringAsync()
                }}, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase })),
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
    }
}
