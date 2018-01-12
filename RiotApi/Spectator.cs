using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public class Spectator
    {
        private static string uri = "spectator/v3/active-games/by-summoner/";

        public double gameId { get; set; }
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime gameStartTime { get; set; }
        public Plataform plataformId { get; set; }
        public GameMode gameMode { get; set; }
        public int mapId { get; set; }
        public GameType gameType { get; set; }
        public int gameQueueConfigId { get; set; }
        public Observers observers { get; set; }
        public List<Participant> participants { get; set; }
        public int gameLength { get; set; }

        public static Spectator GetAsync(int id)
        {
            string retorno = HttpExecute.Execute($"{uri}{id}").Result;
            return retorno == null ? null : JToken.Parse(retorno).ToObject<Spectator>();
        }
    }
    public class Observers
    {
        public string encryptionKey { get; set; }
    }
}
