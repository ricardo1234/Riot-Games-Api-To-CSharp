using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public class Summoner
    {
        public static string Uri = "summoner/v3/summoners/";
        
        public int profileIconId { get; set; }
        public string name { get; set; }
        public int summonerLevel { get; set; }
        public int accountId { get; set; }
        public int id { get; set; }
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime revisionDate { get; set; }

        public static Summoner GetAsync(string parameter, RequestType type)
        {
            string retorno;
            switch (type)
            {
                case RequestType.ById:
                    retorno = HttpExecute.Execute($"{Uri}{parameter}").Result;
                    break;
                case RequestType.ByName:
                    retorno = HttpExecute.Execute($"{Uri}by-name/{parameter}").Result;
                    break;
                case RequestType.ByAccount:
                    retorno = HttpExecute.Execute($"{Uri}by-account/{parameter}").Result;
                    break;
                default:
                    retorno = null;
                    break;
            }
            return retorno == null ? null : JToken.Parse(retorno).ToObject<Summoner>();
        }
    }
}
