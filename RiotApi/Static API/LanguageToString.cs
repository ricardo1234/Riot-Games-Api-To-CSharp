using System.Collections.Generic;
using RiotApi.Some_Logic;

namespace RiotApi.Static_API
{
    public class LanguageToString
    {

        public Dictionary<string, string> data { get; set; }
        public string version { get; set; }
        public string type { get; set; }

        /// <summary>
        /// GetAsync - Used to transform parameters into presentable strings 
        /// </summary>
        /// <returns>LanguageToString or Null</returns>
        public static LanguageToString GetAsync()
        {
            return (LanguageToString)HttpExecute.Execute<LanguageToString>(StaticData.LanguageToStringUri).Result;
        }
    }
}
