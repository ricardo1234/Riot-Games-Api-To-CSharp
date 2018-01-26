using System.Collections.Generic;
using RiotApi.Emuns;
using RiotApi.Some_Logic;
using RiotApi.Static_API.Static_Data_Champs;

namespace RiotApi.Static_API.Static_Data_Summoner
{
    public class SummonerSpell
    {
        private static string Uri = "static-data/v3/summoner-spells/";

        public List<Var> vars { get; set; }
        public Image image { get; set; }
        public string costBurn { get; set; }
        public List<double> cooldown { get; set; }
        public List<string> effectBurn { get; set; }
        public int id { get; set; }
        public string cooldownBurn { get; set; }
        public string tooltip { get; set; }
        public int maxrank { get; set; }
        public string rangeBurn { get; set; }
        public string description { get; set; }
        public List<List<double>> effect { get; set; }
        public string key { get; set; }
        public LevelTip leveltip { get; set; }
        public List<GameMode> modes { get; set; }
        public string resource { get; set; }
        public string name { get; set; }
        public string costType { get; set; }
        public string sanitizedDescription { get; set; }
        public string sanitizedTooltip { get; set; }
        public object range { get; set; }
        public List<int> cost { get; set; }
        public int summonerLevel { get; set; }

        public static SummonerSpell GetAsync(int id)
        {
            return (SummonerSpell)HttpExecute.Execute<SummonerSpell>(Uri + id, "&tags=all").Result;
        }
    }
}