using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RiotApi
{
    public class Champion
    {
        private static string Uri = "platform/v3/champions/";

        public string rankedPlayEnabled { get; set; }
        public bool botEnabled { get; set; }
        public bool botMmEnabled { get; set; }
        public bool active { get; set; }
        public bool freeToPlay { get; set; }
        public int id { get; set; }
        
        public static List<Champion> GetListAsync()
        {
            string retorno = HttpExecute.Execute(Uri).Result;
            return retorno == null ? null : JObject.Parse(retorno)["champions"].ToObject<List<Champion>>();
        }
        public static Champion GetAsync(int id)
        {
            string retorno = HttpExecute.Execute($"{Uri}/{id}").Result;
            return retorno == null ? null : JToken.Parse(retorno).ToObject<Champion>();
        }

    }
}
