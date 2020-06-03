using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for InvolvedCompany
    ///</summary>
    public class InvolvedCompany : IEndpoint
    {
        public ulong Id { get; set; }
        public Company Company { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Developer { get; set; }
        public Game Game { get; set; }
        public bool Porting { get; set; }
        public bool Publisher { get; set; }
        public bool Supporting { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Checksum { get; set; }
    }

}
