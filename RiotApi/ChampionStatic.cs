using Newtonsoft.Json.Linq;
using RiotApi.Static_Data_Champs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public class ChampionStatic
    {
        private static string Uri = "static-data/v3/champions/";

        // Simple Data
        public string lore { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public int id { get; set; }

        //Complex Data
        public List</*Tag*/string> tags { get; set; } // alterar depois
        public List<string> allytips { get; set; } 
        public List<string> enemytips { get; set; }
        public string blurb { get; set; } 
        public Stats stats { get; set; }
        public List<Spell> spells { get; set; }
        public /*Partype*/ string partype { get; set; } //alterar depois para efeitos de teste e limitação da api ficar assim
        public List<Recommended> recommended { get; set; }
        public List<Skin> skins { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public Passive passive { get; set; }

        public static ChampionStatic GetAsync(int id)
        {
            return (ChampionStatic)HttpExecute.Execute<ChampionStatic>($"{Uri}{id}",$"&tags=all").Result;
        }
        public static List<ChampionStatic> GetAllAsync()
        {
            return (List<ChampionStatic>)HttpExecute.Execute<List<ChampionStatic>>(Uri).Result;
            
        }
    }
}
