using System.Collections.Generic;
using RiotApi.Some_Logic;
using RiotApi.Static_API.Static_Data_Champs.Static_Data_Items;

namespace RiotApi.Static_API.Static_Data_Champs
{
    public class Item
    {
        private static string Uri = "static-data/v3/items/";

        //Simple Data
        public int id { get; set; }
        public int count { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string plaintext { get; set; }
        public string sanitizedDescription { get; set; }
        public List<string> tags { get; set; }
        public List<string> into { get; set; }

        //complex Data
        public Image image { get; set; }
        public Gold gold { get; set; }
        public StatsItem stats { get; set; }
        public Dictionary<string, bool> maps { get; set; }

        public static Item GetAsync(int id)
        {
            return (Item)HttpExecute.Execute<Item>($"{Uri}{id}", $"&tags=all").Result;
        }
        public static List<Item> GetAllAsync()
        {
            return (List<Item>)HttpExecute.Execute<List<Item>>(Uri).Result;
        }
    }
}
