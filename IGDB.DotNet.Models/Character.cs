using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Character
    ///</summary>
    public class Character
    {
        public ulong Id { get; set; }
        public IEnumerable<string> Akas { get; set; }
        public string CountryName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public IEnumerable<Game> Games { get; set; }
        public GenderGenderEnum Gender { get; set; }
        public CharacterMugShot MugShot { get; set; }
        public string Name { get; set; }
        public IEnumerable<Person> People { get; set; }
        public string Slug { get; set; }
        public CharacterSpeciesEnum Species { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
