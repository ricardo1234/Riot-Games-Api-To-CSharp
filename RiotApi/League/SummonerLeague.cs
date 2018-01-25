using RiotApi.Emuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.League
{
    public class SummonerLeague
    {
        #region Attributes/Properties

        public Guid leagueId { get; set; }
        public string leagueName { get; set; }
        public Tier tier { get; set; }
        public QueueType queueType { get; set; }
        public Rank rank { get; set; }
        public long playerOrTeamId { get; set; }
        public string playerOrTeamName { get; set; }
        public int leaguePoints { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public bool veteran { get; set; }
        public bool inactive { get; set; }
        public bool freshBlood { get; set; }
        public bool hotStreak { get; set; }

        #endregion

        #region Static Methods

        /// <summary>
        /// Get Flex-5x5, Flex-3x3, Solo-5x5 Leagues From a Summoner
        /// </summary>
        /// <param name="summonerId">System.int - Id of the Requested Summoner</param>
        /// <returns>List of SummonerLeague Objects</returns>
        public static List<SummonerLeague> GetAsync(int summonerId)
        {
            return (List<SummonerLeague>)HttpExecute.Execute<List<SummonerLeague>>($"{StaticData.League_SummonerUri}/{summonerId}").Result;
        }

        #endregion

    }
}
