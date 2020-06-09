using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Search
    ///</summary>
    public class Search : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// AlternativeName
        /// </summary>
        public string AlternativeName { get; set; }

        /// <summary>
        /// Character
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// Collection
        /// </summary>
        public Collection Collection { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        public Company Company { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Person
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// Platform
        /// </summary>
        public Platform Platform { get; set; }

        /// <summary>
        /// Popularity
        /// </summary>
        public double Popularity { get; set; }

        /// <summary>
        /// PublishedAt
        /// </summary>
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// TestDummy
        /// </summary>
        public TestDummy TestDummy { get; set; }

        /// <summary>
        /// Theme
        /// </summary>
        public Theme Theme { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
