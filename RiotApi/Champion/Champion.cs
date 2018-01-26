using System.Collections.Generic;
using RiotApi.Some_Logic;

namespace RiotApi.Champion
{
    public class Champion
    {
        #region Attributes/Properties

        public bool rankedPlayEnabled { get; set; }
        public bool botEnabled { get; set; }
        public bool botMmEnabled { get; set; }
        public bool active { get; set; }
        public bool freeToPlay { get; set; }
        public long id { get; set; }

        #endregion

        #region Static Methods

        /// <summary>
        /// Get Information From All Champions
        /// </summary>
        /// <param name="freeToPlay">System.bool - Select Only Free to Play Champs | Default false</param>
        /// <returns>List of Champions</returns>
        public static List<Champion> GetAllAsync(bool freeToPlay = false) => (List<Champion>)HttpExecute.Execute<List<Champion>>(StaticData.Champion_Uri, $"&freeToPlay={freeToPlay}").Result;
        /// <summary>
        /// Get Information From a Specific Champion
        /// </summary>
        /// <param name="championId">System.long -  Id of the Requested Champion</param>
        /// <returns>Champion</returns>
        public static Champion GetAsync(long championId) => (Champion)HttpExecute.Execute<Champion>($"{StaticData.Champion_Uri}/{championId}").Result;

        #endregion
    }
}
