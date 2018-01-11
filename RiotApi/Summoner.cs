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
        public DateTime revisionDate { get; set; }
    }
}
