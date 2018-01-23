using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Static_Data_Masteries
{
    public class Masteries
    {
        public static string Uri = "static-data/v3/masteries/";

        public Dictionary<string, Mastery> data { get; set; }
        public Tree tree { get; set; }
        public string type { get; set; }
        public string version { get; set; }

        public static Masteries GetAsync()
        {
            return (Masteries)HttpExecute.Execute<Masteries>(Uri, "&tags=all").Result;
        }
    }
}
