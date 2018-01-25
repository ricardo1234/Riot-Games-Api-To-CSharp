using Newtonsoft.Json;
using RiotApi.Emuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Match
{
    public class Match
    {
        private static string Uri = "match/v3/matches/";

        public long gameId { get; set; }
        public Platform platformId { get; set; }
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime gameCreation { get; set; }
        public long gameDuration { get; set; }
        public int queueId { get; set; }
        public int mapId { get; set; }
        public int seasonId { get; set; }
        public string gameVersion { get; set; }
        public GameMode gameMode { get; set; }
        public GameType gameType { get; set; }

        public List<Team> teams { get; set; }
        public List<ParticipantIdentity> participantIdentities { get; set; }
        public List<Participant> participants { get; set; }

        public static Match GetAsync(long id)
        {
            return (Match)HttpExecute.Execute<Match>(Uri + id).Result;
        }

    }
}
