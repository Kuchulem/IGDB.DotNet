﻿namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for Screenshot
    ///</summary>
    public class Screenshot
    {
        public ulong Id { get; set; }
        public bool AlphaChannel { get; set; }
        public bool Animated { get; set; }
        public Game Game { get; set; }
        public int Height { get; set; }
        public string ImageId { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
        public string Checksum { get; set; }
    }

}
