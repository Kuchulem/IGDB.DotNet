using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for User
    ///</summary>
    public class User : IEndpoint
    {
        public ulong Id { get; set; }
        public string Battlenet { get; set; }
        public ColorColorEnum Color { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Discord { get; set; }
        public string Facebook { get; set; }
        public string GooglePlus { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string Origin { get; set; }
        public string Pinterest { get; set; }
        public string Presentation { get; set; }
        public string Reddit { get; set; }
        public UserRoleEnum Role { get; set; }
        public string Slug { get; set; }
        public string Soundcloud { get; set; }
        public string Steam { get; set; }
        public string Twitch { get; set; }
        public string Twitter { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Uplay { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
        public string Youtube { get; set; }
        public string Checksum { get; set; }
    }

}
