namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for ListEntry
    ///</summary>
    public class ListEntry
    {
        public ulong Id { get; set; }
        public string Description { get; set; }
        public Game Game { get; set; }
        public List List { get; set; }
        public Platform Platform { get; set; }
        public int Position { get; set; }
        public bool Private { get; set; }
        public User User { get; set; }
        public string Checksum { get; set; }
    }

}
