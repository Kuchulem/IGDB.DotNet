using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for TestDummy
    ///</summary>
    public class TestDummy : IEndpoint
    {

        /// <summary>
        /// Id
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// BoolValue
        /// </summary>
        public bool BoolValue { get; set; }

        /// <summary>
        /// CreatedAt
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// EnumTest
        /// </summary>
        public TestDummyEnumTestEnum EnumTest { get; set; }

        /// <summary>
        /// FloatValue
        /// </summary>
        public double FloatValue { get; set; }

        /// <summary>
        /// Game
        /// </summary>
        public Game Game { get; set; }

        /// <summary>
        /// IntegerArray
        /// </summary>
        public IEnumerable<int> IntegerArray { get; set; }

        /// <summary>
        /// IntegerValue
        /// </summary>
        public int IntegerValue { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// NewIntegerValue
        /// </summary>
        public int NewIntegerValue { get; set; }

        /// <summary>
        /// Private
        /// </summary>
        public bool Private { get; set; }

        /// <summary>
        /// Slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// StringArray
        /// </summary>
        public IEnumerable<string> StringArray { get; set; }
        // commented to avoid errors
        //public IEnumerable<TestDummy> TestDummies { get; set; }
        //public TestDummy TestDummy { get; set; }

        /// <summary>
        /// UpdatedAt
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// User
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Checksum
        /// </summary>
        public string Checksum { get; set; }
    }

}
