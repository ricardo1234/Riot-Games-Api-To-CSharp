using RiotApi.Emuns;
using System;
using System.Collections.Generic;
using RiotApi.Some_Logic;

namespace RiotApi.League
{
    public class League
    {
        #region Attributes/Properties

        public string name { get; set; }
        public Tier tier { get; set; }
        public QueueType queue { get; set; }
        public Guid leagueId { get; set; }
        public List<SummonerLeague> entries { get; set; }

        #endregion

        #region Static Methods 

        /// <summary>
        /// Get players in Challenger League
        /// </summary>
        /// <param name="queue">RiotApi.Emuns.QueueType - Enumerable QueueType</param>
        /// <returns>League Object</returns>
        public static League GetChallengerSeriesAsync(QueueType queue) => (League)HttpExecute.Execute<League>($"{StaticData.League_UriChallenger}/{queue}").Result;

        /// <summary>
        ///  Get players in Master League
        /// </summary>
        /// <param name="queue">RiotApi.Emuns.QueueType - Enumerable QueueType</param>
        /// <returns>League Object</returns>
        public static League GetMasterSeriesAsync(QueueType queue) => (League)HttpExecute.Execute<League>($"{StaticData.League_UriMaster}/{queue}").Result;

        /// <summary>
        /// Get players in a League
        /// </summary>
        /// <param name="guidLeague">System.Guid - League Id format to Guid</param>
        /// <returns>League Object</returns>
        public static League GetLeagueAsync(Guid guidLeague) => (League)HttpExecute.Execute<League>($"{StaticData.League_Uri}/{guidLeague}").Result;

        #endregion
    }
}
