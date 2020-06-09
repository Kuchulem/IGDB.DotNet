using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for User
    ///</summary>
    public class User : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Battlenet
        /// </summary>
        public string Battlenet { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        public ColorColorEnum Color { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Discord
        /// </summary>
        public string Discord { get; set; }

        /// <summary>
        /// Facebook
        /// </summary>
        public string Facebook { get; set; }

        /// <summary>
        /// GooglePlus
        /// </summary>
        public string GooglePlus { get; set; }

        /// <summary>
        /// Instagram
        /// </summary>
        public string Instagram { get; set; }

        /// <summary>
        /// Linkedin
        /// </summary>
        public string Linkedin { get; set; }

        /// <summary>
        /// Origin
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Pinterest
        /// </summary>
        public string Pinterest { get; set; }

        /// <summary>
        /// Presentation
        /// </summary>
        public string Presentation { get; set; }

        /// <summary>
        /// Reddit
        /// </summary>
        public string Reddit { get; set; }

        /// <summary>
        /// Role
        /// </summary>
        public UserRoleEnum Role { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Soundcloud
        /// </summary>
        public string Soundcloud { get; set; }

        /// <summary>
        /// Steam
        /// </summary>
        public string Steam { get; set; }

        /// <summary>
        /// Twitch
        /// </summary>
        public string Twitch { get; set; }

        /// <summary>
        /// Twitter
        /// </summary>
        public string Twitter { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Uplay
        /// </summary>
        public string Uplay { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Youtube
        /// </summary>
        public string Youtube { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
