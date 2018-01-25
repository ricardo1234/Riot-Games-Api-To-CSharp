using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Static_Data_Summoner
{
    public class SummonerSpells
    {
        private static string Uri = "static-data/v3/summoner-spells/";

        public string type { get; set; }
        public string version { get; set; }
        public Dictionary<string, SummonerSpell> data { get; set; }

        public static SummonerSpells GetAsync()
        {
            return (SummonerSpells)HttpExecute.Execute<SummonerSpells>(Uri,"&tags=all").Result;
        }
    }
}
