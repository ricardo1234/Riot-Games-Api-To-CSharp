using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RiotApi.Emuns;
using RiotApi.Some_Logic;

namespace RiotApi.Champion_Mastery
{
    public class ChampionMastery
    {
        #region Attributes/Properties

        public int championLevel { get; set; }
        public bool chestGranted { get; set; }
        public int championPoints { get; set; }
        public long championPointsSinceLastLevel { get; set; }
        public long playerId { get; set; }
        public long championPointsUntilNextLevel { get; set; }
        public int tokensEarned { get; set; }
        public long championId { get; set; }
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime lastPlayTime { get; set; }

        #endregion

        #region Static Methods

        /// <summary>
        /// Get the Mastery of Champions or Champion for Specific Summoner
        /// </summary>
        /// <param name="idSummoner">System.long - Id of the Requested Summoner | Required</param>
        /// <param name="type">Riot.Enuns.RequestType - Permited: BySummoner, ByChampAndSummoner | Required</param>
        /// <param name="idChampion">System.string - Id of a Specific Champion | Required If RequestType.ByChampAndSummoner</param>
        /// <returns>RequestType.BySummoner: List of ChampionMastery | RequestType.ByChampAndSummoner: ChampionMastery</returns>
        public static object GetAsync(long idSummoner, RequestType type, string idChampion = null)
        {
            switch (type)
            {
                case RequestType.BySummoner:
                    return (List<ChampionMastery>)HttpExecute.Execute<List<ChampionMastery>>($"{StaticData.ChampionMastery_Uri}/{idSummoner}").Result;
                case RequestType.ByChampAndSummoner:
                    return (ChampionMastery)HttpExecute.Execute<ChampionMastery>($"{StaticData.ChampionMastery_Uri}/{idSummoner}{StaticData.ChampionMastery_UriByChamp}/{idChampion}").Result;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Get the Summoner Total Score, which is the sum of individual champion mastery levels.
        /// </summary>
        /// <param name="idSummoner">System.long - Id of the Requested Summoner</param>
        /// <returns>System.int</returns>
        public static int GetScoreAsync(long idSummoner)
        {
            return (int)HttpExecute.Execute<int>($"{StaticData.ChampionMastery_ScoreUri}/{idSummoner}").Result;
        }
        #endregion
    }
}
