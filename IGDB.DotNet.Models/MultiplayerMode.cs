namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for MultiplayerMode
    ///</summary>
    public class MultiplayerMode : IEndpoint
    {
        public ulong Id { get; set; }
        public bool Campaigncoop { get; set; }
        public bool Dropin { get; set; }
        public Game Game { get; set; }
        public bool Lancoop { get; set; }
        public bool Offlinecoop { get; set; }
        public int Offlinecoopmax { get; set; }
        public int Offlinemax { get; set; }
        public bool Onlinecoop { get; set; }
        public int Onlinecoopmax { get; set; }
        public int Onlinemax { get; set; }
        public Platform Platform { get; set; }
        public bool Splitscreen { get; set; }
        public bool Splitscreenonline { get; set; }
        public string Checksum { get; set; }
    }

}
