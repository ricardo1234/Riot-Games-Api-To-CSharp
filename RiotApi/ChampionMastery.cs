using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public class ChampionMastery
    {
        public static string Uri = "champion-mastery/v3/champion-masteries/by-summoner/";
        public static string UriByChamp = "/by-champion/";

        public int championLevel { get; set; }
        public bool chestGranted { get; set; }
        public int championPoints { get; set; }
        public int championPointsSinceLastLevel { get; set; }
        public int playerId { get; set; }
        public int championPointsUntilNextLevel { get; set; }
        public int tokensEarned { get; set; }
        public int championId { get; set; }
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime lastPlayTime { get; set; }

        public static List<ChampionMastery> GetAsync(string idSummoner, RequestType type, string idChampion = null)
        {
            string retorno = null;
            switch (type)
            {
                case RequestType.BySummoner:
                    retorno = HttpExecute.Execute($"{Uri}{idSummoner}").Result;
                    break;
                case RequestType.ByChampAndSummoner:
                    retorno = HttpExecute.Execute($"{Uri}{idSummoner}{UriByChamp}{idChampion}").Result;
                    break;
                default:
                    break;
            }
            return retorno == null ? null : JToken.Parse(retorno).Root.ToObject<List<ChampionMastery>>();
        }
    }
}
