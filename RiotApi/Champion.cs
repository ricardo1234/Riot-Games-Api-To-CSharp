using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public class Champion
    {
        private static string Uri = "platform/v3/champions";

        public string rankedPlayEnabled { get; set; }
        public bool botEnabled { get; set; }
        public bool botMmEnabled { get; set; }
        public bool active { get; set; }
        public bool freeToPlay { get; set; }
        public int id { get; set; }

        public static Champion descerialize(JToken jUser)
        {
            return new Champion()
            {
                rankedPlayEnabled = (string)jUser["rankedPlayEnabled"],
                botEnabled = (bool)jUser["botEnabled"],
                botMmEnabled = (bool)jUser["botMmEnabled"],
                active = (bool)jUser["active"],
                freeToPlay = (bool)jUser["freeToPlay"],
                id = (int)jUser["id"]
            };
        }
        public static List<Champion> descerializeList(string json)
        {
            List<Champion> ret = new List<Champion>();
            foreach (var item in JObject.Parse(json)["champions"])
                ret.Add(descerialize(item));
            return ret;
        }
        public static List<Champion> GetListAsync()
        {
            string retorno = HttpExecute.Execute(Uri).Result;
            return retorno == null ? null : descerializeList(retorno);
        }
        public static Champion GetAsync(int id)
        {
            string retorno = HttpExecute.Execute(Uri+ id.ToString()).Result;
            return retorno == null ? null : descerialize(retorno);
        }


    }
}
