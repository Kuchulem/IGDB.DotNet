using IGDB.DotNet.Models.Enums;
using System;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Credit
    ///</summary>
    public class Credit
    {
        public ulong Id { get; set; }
        public CreditCategoryEnum Category { get; set; }
        public Character Character { get; set; }
        public string CharacterCreditedName { get; set; }
        public string Comment { get; set; }
        public Company Company { get; set; }
        public int Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreditedName { get; set; }
        public Game Game { get; set; }
        public Person Person { get; set; }
        public Title PersonTitle { get; set; }
        public int Position { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Checksum { get; set; }
    }

}
