using Apicalypse.DotNet;
using IGDB.DotNet.Client.Configuration;
using IGDB.DotNet.Client.Endpoints;
using IGDB.DotNet.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace IGDB.DotNet.Client
{
    /// <summary>
    /// Entry point for the lib
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class IgdbClient<T>
        where T : IEndpoint
    {
        private const string UserKeyHeaderName = "user-key";

        private readonly IIgdbConfiguration igdbConfiguration;
        private Action<RequestBuilder<T>> query;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="igdbConfiguration"></param>
        public IgdbClient(IIgdbConfiguration igdbConfiguration)
        {
            this.igdbConfiguration = igdbConfiguration;
        }

        /// <summary>
        /// Defines the query statements
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IgdbClient<T> Query(Action<RequestBuilder<T>> query)
        {
            if (query is null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            this.query = query;

            return this;
        }

        /// <summary>
        /// Calls the API and gets the results
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="httpClient"></param>
        /// <returns></returns>
        public Task<IEnumerable<TResult>> Call<TResult>(HttpClient httpClient)
            where TResult : new()
        {
            if (query is null)
                throw new Exception("No query provided");

            if (httpClient is null)
                throw new ArgumentNullException(nameof(httpClient));

            httpClient.BaseAddress = igdbConfiguration.IgbdUrl;

            if (httpClient.DefaultRequestHeaders.Contains(UserKeyHeaderName))
                httpClient.DefaultRequestHeaders.Remove(UserKeyHeaderName);

            httpClient.DefaultRequestHeaders.Add(UserKeyHeaderName, igdbConfiguration.UserToken);

            var builder = new RequestBuilder<T>(new Apicalypse.DotNet.Configuration.RequestBuilderConfiguration
            {
                CaseContract = Apicalypse.DotNet.Configuration.CaseContract.SnakeCase
            });

            query.Invoke(builder);

            return builder.Build().Send<TResult>(httpClient, EndpointMapper.Map<T>());
        }
    }
}
