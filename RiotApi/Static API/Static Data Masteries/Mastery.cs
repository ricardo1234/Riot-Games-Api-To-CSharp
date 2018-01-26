using System.Collections.Generic;
using RiotApi.Some_Logic;
using RiotApi.Static_API.Static_Data_Champs;

namespace RiotApi.Static_API.Static_Data_Masteries
{
    public class Mastery
    {
        public static string Uri = "static-data/v3/masteries/";

        public int id { get; set; }
        public string name { get; set; }
        public List<string> description { get; set; }
        public List<string> sanitizedDescription { get; set; }
        public int ranks { get; set; }
        public string prereq { get; set; }
        public Image image { get; set; }
        public string masteryTree { get; set; }

        public static Mastery GetAsync(int id)
        {
            return (Mastery)HttpExecute.Execute<Mastery>(Uri+id, "&tags=all").Result;
        }
    }
}
