using IGDB.DotNet.Client;
using IGDB.DotNet.Models;
using IGDB.DotNet.Tests.Mocks;
using IGDB.DotNet.Tests.Models;
using NUnit.Framework;
using System;
using System.Linq;
using System.Net.Http;

namespace IGDB.DotNet.Tests
{
    public class IgdbClient_CallShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThrowExceptionWhenQueryNotProvidedTest()
        {
            Assert.Throws<Exception>(() =>
            {
                using var mockedHttpClient = new HttpClient(new HttpMessageHandlerMock());
                var config = new IgdbConfiguration();
                var result = (new IgdbClient<Game>(new IgdbConfiguration()))
                    .Call<HttpMockModel>(mockedHttpClient)
                    .GetAwaiter().GetResult()
                    .FirstOrDefault();
            });
        }

        [Test]
        public void SetRightAddressTest()
        {
            using var mockedHttpClient = new HttpClient(new HttpMessageHandlerMock());
            var config = new IgdbConfiguration();
            var result = (new IgdbClient<Game>(new IgdbConfiguration()))
                .Query(b => b.Select(g => g.Name))
                .Call<HttpMockModel>(mockedHttpClient)
                .GetAwaiter().GetResult()
                .FirstOrDefault();

            Assert.AreEqual(config.IgbdUrl + "games", result.Url);
        }

        [Test]
        public void SetUserKeyTest()
        {
            using var mockedHttpClient = new HttpClient(new HttpMessageHandlerMock());
            var config = new IgdbConfiguration();
            var result = (new IgdbClient<Game>(new IgdbConfiguration()))
                .Query(b => b.Select(g => g.Name))
                .Call<HttpMockModel>(mockedHttpClient)
                .GetAwaiter().GetResult()
                .FirstOrDefault();

            Assert.AreEqual(config.UserToken, result.UserKeyHeader);
        }

        [Test]
        public void RemovesPreviousHeaderTest()
        {
            using var mockedHttpClient = new HttpClient(new HttpMessageHandlerMock());
            mockedHttpClient.DefaultRequestHeaders.Add("user-key", "unexpected-key");
            var config = new IgdbConfiguration();
            var result = (new IgdbClient<Game>(new IgdbConfiguration()))
                .Query(b => b.Select(g => g.Name))
                .Call<HttpMockModel>(mockedHttpClient)
                .GetAwaiter().GetResult()
                .FirstOrDefault();

            Assert.AreEqual(1, result.UserKeyHeaderCount);
        }

        [Test]
        public void RemovesAllPreviousHeadersTest()
        {
            using var mockedHttpClient = new HttpClient(new HttpMessageHandlerMock());
            mockedHttpClient.DefaultRequestHeaders.Add("user-key", "unexpected-key");
            mockedHttpClient.DefaultRequestHeaders.Add("user-key", "other-unexpected-key");
            var config = new IgdbConfiguration();
            var result = (new IgdbClient<Game>(new IgdbConfiguration()))
                .Query(b => b.Select(g => g.Name))
                .Call<HttpMockModel>(mockedHttpClient)
                .GetAwaiter().GetResult()
                .FirstOrDefault();

            Assert.AreEqual(1, result.UserKeyHeaderCount);
        }
    }
}