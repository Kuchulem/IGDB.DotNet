using IGDB.DotNet.Models.Enums;
using System;
using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for TestDummy
    ///</summary>
    public class TestDummy
    {
        public ulong Id { get; set; }
        public bool BoolValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public TestDummyEnumTestEnum EnumTest { get; set; }
        public double FloatValue { get; set; }
        public Game Game { get; set; }
        public IEnumerable<int> IntegerArray { get; set; }
        public int IntegerValue { get; set; }
        public string Name { get; set; }
        public int NewIntegerValue { get; set; }
        public bool Private { get; set; }
        public string Slug { get; set; }
        public IEnumerable<string> StringArray { get; set; }
        // commented to avoid errors
        //public IEnumerable<TestDummy> TestDummies { get; set; }
        //public TestDummy TestDummy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public User User { get; set; }
        public string Checksum { get; set; }
    }

}
