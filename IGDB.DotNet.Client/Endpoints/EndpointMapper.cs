using Apicalypse.DotNet.Extensions;
using IGDB.DotNet.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace IGDB.DotNet.Client.Endpoints
{
    internal static class EndpointMapper
    {
        /// <summary>
        /// Maps the API endpoints with the API models
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string Map<T>()
            where T : IEndpoint
        {
            // this is a temp shorthand
            return typeof(T).Name switch
            {
                // particular plurals
                "Company" => "companies",
                "PlatformVersionCompany" => "platform_version_companies",
                "ProductFamily" => "product_families",
                // private endpoints
                "FeedFollow" => "private/feed_follows",
                "Follow" => "private/follows",
                "List" => "private/lists",
                "ListEntry" => "private/list_entries",
                "Rate" => "private/rates",
                "Review" => "private/reviews",
                "ReviewVideo" => "private/review_videos",
                _ => typeof(T).Name.ToSnakeCase() + "s"
            };
        }
    }
}
