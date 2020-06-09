using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Pulse
    ///</summary>
    public class Pulse : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public int Category { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Ignored
        /// </summary>
        public bool Ignored { get; set; }

        /// <summary>
        /// Image
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// PublishedAt
        /// </summary>
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// PulseImage
        /// </summary>
        public PulseImage PulseImage { get; set; }

        /// <summary>
        /// PulseSource
        /// </summary>
        public PulseSource PulseSource { get; set; }

        /// <summary>
        /// Summary
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        public IEnumerable<int> Tags { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Uid
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Videos
        /// </summary>
        public IEnumerable<string> Videos { get; set; }

        /// <summary>
        /// Website
        /// </summary>
        public PulseUrl Website { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
