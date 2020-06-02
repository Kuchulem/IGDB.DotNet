using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Person
    ///</summary>
    public class Person
    {
        public ulong Id { get; set; }
        public string Bio { get; set; }
        public IEnumerable<Character> Characters { get; set; }
        public int Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<Game> CreditedGames { get; set; }
        public string Description { get; set; }
        public DateTime Dob { get; set; }
        public GenderGenderEnum Gender { get; set; }
        public int LovesCount { get; set; }
        public PersonMugShot MugShot { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Nicknames { get; set; }
        public Person Parent { get; set; }
        public string Slug { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public IEnumerable<Game> VoiceActed { get; set; }
        public IEnumerable<PersonWebsite> Websites { get; set; }
        public string Checksum { get; set; }
    }

}
