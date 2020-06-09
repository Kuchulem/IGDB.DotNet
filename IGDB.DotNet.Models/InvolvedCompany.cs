using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for InvolvedCompany
    ///</summary>
    public class InvolvedCompany : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        public Company Company { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Developer
        /// </summary>
        public bool Developer { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Porting
        /// </summary>
        public bool Porting { get; set; }

        /// <summary>
        /// Publisher
        /// </summary>
        public bool Publisher { get; set; }

        /// <summary>
        /// Supporting
        /// </summary>
        public bool Supporting { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
