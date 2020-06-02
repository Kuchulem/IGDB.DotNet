namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Rate
    ///</summary>
    public class Rate
    {
        public ulong Id { get; set; }
        public Game Game { get; set; }
        public bool Private { get; set; }
        public double Rating { get; set; }
        public User User { get; set; }
        public string Checksum { get; set; }
    }

}
