using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Person
    ///</summary>
    public class Person : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Bio
        /// </summary>
        public string Bio { get; set; }

        /// <summary>
        /// Characters
        /// </summary>
        public IEnumerable<Character> Characters { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public int Country { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// CreditedGames
        /// </summary>
        public IEnumerable<Game> CreditedGames { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Dob
        /// </summary>
        public DateTime Dob { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public GenderGenderEnum Gender { get; set; }

        /// <summary>
        /// LovesCount
        /// </summary>
        public int LovesCount { get; set; }

        /// <summary>
        /// MugShot
        /// </summary>
        public PersonMugShot MugShot { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Nicknames
        /// </summary>
        public IEnumerable<string> Nicknames { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        public Person Parent { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// VoiceActed
        /// </summary>
        public IEnumerable<Game> VoiceActed { get; set; }

        /// <summary>
        /// Websites
        /// </summary>
        public IEnumerable<PersonWebsite> Websites { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
