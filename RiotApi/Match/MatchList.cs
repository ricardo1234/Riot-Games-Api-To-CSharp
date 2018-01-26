using System.Collections.Generic;
using System.Runtime.InteropServices;
using RiotApi.Some_Logic;

namespace RiotApi.Match
{
    public class MatchList
    {
        

        public List<SimpleMatch> matches { get; set; }
        public int startIndex { get; set; }
        public int endIndex { get; set; }
        public int totalGames { get; set; }

        /// <summary>
        /// Get the Match List with the 
        /// </summary>
        /// <param name="accountId">System.long - Id of the Requested Account</param>
        /// <param name="recent">System.bool - Return Just Last 20 Games | Defaul: False</param>
        /// <returns>MatchList</returns>
        public static MatchList GetAsync(long accountId, int queue = -1, long endTime = -1,int beginIndex = -1 ,bool recent = false) => 
            (MatchList)HttpExecute.Execute<MatchList>(StaticData.MatchList_Uri + accountId + (recent ? "/recent" : ""),(queue != -1 ? $"&queue={queue}" : "") + (endTime != -1 ? $"&endTime={endTime}" : "")).Result;
    }
}
