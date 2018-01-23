using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Match
{
    public class TimeLine
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
