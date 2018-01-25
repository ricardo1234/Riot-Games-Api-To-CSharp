using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using RiotApi.Emuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public class Summoner
    {
        
        public int profileIconId { get; set; }
        public string name { get; set; }
        public int summonerLevel { get; set; }
        public long  accountId { get; set; }
        public long id { get; set; }
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime revisionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter">Could be: String - whith the Summoner Name, </param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Summoner GetAsync(string parameter, RequestType type)
        {
                switch (type)
                {
                    case RequestType.ById:
                        return (Summoner)HttpExecute.Execute<Summoner>($"{StaticData.SummonerUri}{parameter}").Result;
                    case RequestType.ByName:
                        return (Summoner)HttpExecute.Execute<Summoner>($"{StaticData.SummonerUri}by-name/{parameter}").Result;
                    case RequestType.ByAccount:
                        return (Summoner)HttpExecute.Execute<Summoner>($"{StaticData.SummonerUri}by-account/{parameter}").Result;
                    default:
                        return null;
                }
        }
    }
}
