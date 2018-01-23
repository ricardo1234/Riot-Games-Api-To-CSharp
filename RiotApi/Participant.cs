using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public class Participant
    {
        public int profileIconId { get; set; }
        public int championId { get; set; }
        public string summonerName { get; set; }
        public int summonerId { get; set; }
        public object gameCustomizationObjects { get; set; }
        public bool bot { get; set; }
        public Perks perks { get; set; }
        public int spell2Id { get; set; }
        public int spell1Id { get; set; }
        public int teamId { get; set; }
    }
}
