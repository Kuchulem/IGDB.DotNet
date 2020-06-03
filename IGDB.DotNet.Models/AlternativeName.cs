namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for AlternativeName
    ///</summary>
    public class AlternativeName : IEndpoint
    {
        public ulong Id { get; set; }
        public string Comment { get; set; }
        public Game Game { get; set; }
        public string Name { get; set; }
        public string Checksum { get; set; }
    }

}
