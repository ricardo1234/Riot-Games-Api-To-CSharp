using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RiotApi.Emuns;
using RiotApi.Some_Logic;

namespace RiotApi.Spectator
{
    public class Spectator
    {
        #region Attributes/Properties

        public long gameLength { get; set; }
        public long gameQueueConfigId { get; set; }
        public long mapId { get; set; }
        public long gameId { get; set; }
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime gameStartTime { get; set; }
        public Platform plataformId { get; set; }
        public GameMode gameMode { get; set; }
        public GameType gameType { get; set; }
        public Observers observers { get; set; }
        public List<Participant> participants { get; set; }

        #endregion

        #region Static Methods

        /// <summary>
        /// Get To Know Current Game Information for a Specific Summoner
        /// </summary>
        /// <param name="summonerId">System.long - Id og the Requested Summoner</param>
        /// <returns>Spectator</returns>
        public static Spectator GetAsync(long summonerId) => (Spectator)HttpExecute.Execute<Spectator>($"{StaticData.Spectator_Uri}{summonerId}").Result;
        #endregion
    }
}
