using IGDB.DotNet.Models.Enums;
using System.Text;

namespace IGDB.DotNet.Models
{    ///<summary>
    /// Model description for Website
    ///</summary>
    public class Website
    {
        public ulong Id { get; set; }
        public WebsiteCategoryEnum Category { get; set; }
        public Game Game { get; set; }
        public bool Trusted { get; set; }
        public string Url { get; set; }
        public string Checksum { get; set; }
    }

}
