using System.Collections.Generic;

namespace IGDB.DotNet.Models
{
    ///<summary>
    /// Model description for AchievementResult
    ///</summary>
    public class AchievementResult
    {

        /// <summary>
        /// Achievements
        /// </summary>
        public IEnumerable<Achievement> Achievements { get; set; }
    }

}
