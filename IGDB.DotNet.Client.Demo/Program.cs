using IGDB.DotNet.Client.Configuration;
using IGDB.DotNet.Client.Demo.Models;
using IGDB.DotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace IGDB.DotNet.Client.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("Please privide your IGDB user key as argument :)");
                return;
            }

            var config = new Config
            {
                UserToken = args[0]
            };

            IEnumerable<GameShort> results;

            using (var client = new HttpClient())
                results = new IgdbClient<Game>(config)
                    .Query(builder =>
                        builder
                            .Select<GameShort>()
                            .Where(g => g.Name.EndsWith("Foo", StringComparison.InvariantCultureIgnoreCase))
                    )
                    .Call<GameShort>(client).GetAwaiter().GetResult();


            if(results is null)
            {
                Console.WriteLine("No result, something when badly");
            }

            Console.WriteLine($"Found {results.Count()} results :");
            foreach(var result in results)
            {
                Console.WriteLine($"  > {result.Name}");
            }
        }
    }

    public class Config : IIgdbConfiguration
    {
        public Uri IgbdUrl => new Uri("https://api-v3.igdb.com");

        public string UserToken { get; set; }
    }
}
