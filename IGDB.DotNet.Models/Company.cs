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

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// ChangeDate
        /// </summary>
        public DateTime ChangeDate { get; set; }

        /// <summary>
        /// ChangeDateCategory
        /// </summary>
        public DateFormatChangeDateCategoryEnum ChangeDateCategory { get; set; }

        /// <summary>
        /// ChangedCompanyId
        /// </summary>
        public Company ChangedCompanyId { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public int Country { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Developed
        /// </summary>
        public IEnumerable<Game> Developed { get; set; }

        /// <summary>
        /// Logo
        /// </summary>
        public CompanyLogo Logo { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        public Company Parent { get; set; }

        /// <summary>
        /// Published
        /// </summary>
        public IEnumerable<Game> Published { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// StartDate
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// StartDateCategory
        /// </summary>
        public DateFormatChangeDateCategoryEnum StartDateCategory { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Websites
        /// </summary>
        public IEnumerable<CompanyWebsite> Websites { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
