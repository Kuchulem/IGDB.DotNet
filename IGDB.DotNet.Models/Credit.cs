using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Credit
    ///</summary>
    public class Credit : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public CreditCategoryEnum Category { get; set; }

        /// <summary>
        /// Character
        /// </summary>
        public Character Character { get; set; }

        /// <summary>
        /// CharacterCreditedName
        /// </summary>
        public string CharacterCreditedName { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        public Company Company { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public int Country { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// CreditedName
        /// </summary>
        public string CreditedName { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// Person
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// PersonTitle
        /// </summary>
        public Title PersonTitle { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
