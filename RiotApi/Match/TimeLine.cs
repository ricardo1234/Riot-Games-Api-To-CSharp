using RiotApi.Emuns;
using System.Collections.Generic;

namespace RiotApi.Match
{
    public class SimpleTimeLine
    {
        public int participantId { get; set; }
        public Dictionary<string, double> creepsPerMinDeltas { get; set; }
        public Dictionary<string, double> xpPerMinDeltas { get; set; }
        public Dictionary<string, double> goldPerMinDeltas { get; set; }
        public Dictionary<string, double> damageTakenPerMinDeltas { get; set; }
        public Roles role { get; set; }
        public Lanes lane { get; set; }
    }
}
