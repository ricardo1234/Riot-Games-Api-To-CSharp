using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi
{
    public class LanguageToString
    {
        public static string Uri = "static-data/v3/language-strings/";

        public Dictionary<string, string> data { get; set; }
        public string version { get; set; }
        public string type { get; set; }

        /// <summary>
        /// GetAsync - Used to transform parameters into presentable strings 
        /// </summary>
        /// <returns>LanguageToString or Null</returns>
        public static LanguageToString GetAsync()
        {
            return (LanguageToString)HttpExecute.Execute<LanguageToString>(Uri).Result;
        }
    }
}
