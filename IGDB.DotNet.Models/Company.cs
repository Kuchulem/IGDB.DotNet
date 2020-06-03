using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Company
    ///</summary>
    public class Company : IEndpoint
    {
        public ulong Id { get; set; }
        public DateTime ChangeDate { get; set; }
        public DateFormatChangeDateCategoryEnum ChangeDateCategory { get; set; }
        public Company ChangedCompanyId { get; set; }
        public int Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public IEnumerable<Game> Developed { get; set; }
        public CompanyLogo Logo { get; set; }
        public string Name { get; set; }
        public Company Parent { get; set; }
        public IEnumerable<Game> Published { get; set; }
        public string Slug { get; set; }
        public DateTime StartDate { get; set; }
        public DateFormatChangeDateCategoryEnum StartDateCategory { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public IEnumerable<CompanyWebsite> Websites { get; set; }
        public string Checksum { get; set; }
    }

}
