using RiotApi.Static_Data_Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
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
