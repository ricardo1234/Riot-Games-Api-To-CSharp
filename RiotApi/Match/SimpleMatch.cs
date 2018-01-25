using Newtonsoft.Json;
using RiotApi.Emuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Match
{
    public class SimpleMatch
    {
        public Platform platformId { get; set; }
        public long gameId { get; set; }
        public int champion { get; set; }
        public int queue { get; set; }
        public int season { get; set; }
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime timestamp { get; set; }
        public string role { get; set; }
        public string lane { get; set; }
    }
}
