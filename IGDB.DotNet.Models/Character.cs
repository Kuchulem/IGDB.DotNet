using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Character
    ///</summary>
    public class Character : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Akas
        /// </summary>
        public IEnumerable<string> Akas { get; set; }

        /// <summary>
        /// CountryName
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Games
        /// </summary>
        public IEnumerable<Game> Games { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public GenderGenderEnum Gender { get; set; }

        /// <summary>
        /// MugShot
        /// </summary>
        public CharacterMugShot MugShot { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// People
        /// </summary>
        public IEnumerable<Person> People { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Species
        /// </summary>
        public CharacterSpeciesEnum Species { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
