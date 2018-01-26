using System;
using Newtonsoft.Json;
using RiotApi.Emuns;
using RiotApi.Some_Logic;

namespace RiotApi.Summoner
{
    public class Summoner
    {
        #region Attributes/Properties

        public int profileIconId { get; set; }
        public string name { get; set; }
        public int summonerLevel { get; set; }
        public long  accountId { get; set; }
        public long id { get; set; }
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime revisionDate { get; set; }

        #endregion

        #region Static Methods

        /// <summary>
        /// Get Infotmation for a Specific Summoner, by 3 diferant ways. By the Summoner Name, Account Id or Summoner Id
        /// </summary>
        /// <param name="parameter"> System.string - Summoner Name: RequestType.ByName, Account Id: RequestType.ByAccount or Summoner Id: RequestType.ById</param>
        /// <param name="requestType">System.RequestType - Permited: ById, ByName, ByAccount</param>
        /// <returns>Summoner</returns>
        public static Summoner GetAsync(string parameter, RequestType requestType)
        {
            switch (requestType)
            {
                case RequestType.ById:
                    return (Summoner)HttpExecute.Execute<Summoner>($"{StaticData.Summoner_Uri}{parameter}").Result;
                case RequestType.ByName:
                    return (Summoner)HttpExecute.Execute<Summoner>($"{StaticData.Summoner_Uri}by-name/{parameter}").Result;
                case RequestType.ByAccount:
                    return (Summoner)HttpExecute.Execute<Summoner>($"{StaticData.Summoner_Uri}by-account/{parameter}").Result;
                default:
                    return null;
            }
        }
        #endregion
    }
}
