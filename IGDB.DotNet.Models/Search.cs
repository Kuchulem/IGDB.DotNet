using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Search
    ///</summary>
    public class Search : IEndpoint
    {
        public ulong Id { get; set; }
        public string AlternativeName { get; set; }
        public Character Character { get; set; }
        public Collection Collection { get; set; }
        public Company Company { get; set; }
        public string Description { get; set; }
        public Game Game { get; set; }
        public string Name { get; set; }
        public Person Person { get; set; }
        public Platform Platform { get; set; }
        public double Popularity { get; set; }
        public DateTime PublishedAt { get; set; }
        public TestDummy TestDummy { get; set; }
        public Theme Theme { get; set; }
        public string Checksum { get; set; }
    }

}
