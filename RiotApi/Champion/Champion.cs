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

        /// <summary>
        /// GetAllAsync - Get Some Information From All Champions
        /// </summary>
        /// <returns>Champion List or Null</returns>
        public static List<Champion> GetAllAsync()
        {
            return (List<Champion>)HttpExecute.Execute<List<Champion>>(Uri).Result;
        }
        /// <summary>
        /// GetAsync - Get Some Information From one Champion
        /// </summary>
        /// <param name="id">Champion Id</param>
        /// <returns>Champion or Null</returns>
        public static Champion GetAsync(int id)
        {
            return (Champion)HttpExecute.Execute<Champion>($"{Uri}/{id}").Result;
        }

    }
}
