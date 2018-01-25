using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RiotApi.Emuns;
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

        //Simple Data
        public int gameLength { get; set; }
        public int gameQueueConfigId { get; set; }
        public int mapId { get; set; }
        public double gameId { get; set; }
        //Complex Data
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime gameStartTime { get; set; }
        public Platform plataformId { get; set; }
        public GameMode gameMode { get; set; }
        public GameType gameType { get; set; }
        public Observers observers { get; set; }
        public List<Participant> participants { get; set; }

        /// <summary>
        /// GetAsync - Get To Know Current Game Information
        /// </summary>
        /// <param name="id">Summoner Id</param>
        /// <returns>Spectator or null (if no game has been found)</returns>
        public static Spectator GetAsync(int id)
        {
            return (Spectator)HttpExecute.Execute<Spectator>($"{uri}{id}").Result;
        }
    }
}
