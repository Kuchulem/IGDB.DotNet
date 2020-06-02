namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for TimeToBeat
    ///</summary>
    public class TimeToBeat
    {
        public ulong Id { get; set; }
        public int Completely { get; set; }
        public Game Game { get; set; }
        public int Hastly { get; set; }
        public int Normally { get; set; }
        public string Checksum { get; set; }
    }

}
