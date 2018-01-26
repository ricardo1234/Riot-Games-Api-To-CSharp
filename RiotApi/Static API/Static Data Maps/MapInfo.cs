using System.Collections.Generic;
using RiotApi.Some_Logic;

namespace RiotApi.Static_API.Static_Data_Maps
{
    public class MapInfo
    {
        public static string Uri = "static-data/v3/maps";

        public string type { get; set; }
        public string version { get; set; }
        public Dictionary<string, Map> data { get; set; }

        public static MapInfo GetAsync()
        {
            return (MapInfo)HttpExecute.Execute<MapInfo>(Uri).Result;
        }
    }
}
