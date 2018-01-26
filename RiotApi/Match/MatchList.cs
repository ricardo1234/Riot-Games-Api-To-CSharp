using System.Collections.Generic;
using RiotApi.Some_Logic;

namespace RiotApi.Match
{
    public class MatchList
    {
        private static string Uri = "match/v3/matchlists/by-account/";

        public List<SimpleMatch> matches { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
        public int totalGames { get; set; }

        public static MatchList GetAsync(int id)
        {
            return (MatchList)HttpExecute.Execute<MatchList>(Uri+id).Result;
        }
    }
}
