using Newtonsoft.Json.Linq;
using RiotApi.Static_Data_Champs;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RiotApi
{
    public static class HttpExecute
    {
        public static async Task<object> Execute<T>(string uri, string parammeters = "")
        {
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
               string retorno = null;
                response = await client.GetAsync(string.Format("{0}{1}{2}{3}", StaticData.BaseUrl, uri, StaticData.APIKey, parammeters));

                if (response.IsSuccessStatusCode)
                    retorno = await response.Content.ReadAsStringAsync();
                if (retorno == null)
                    return null;

                switch (typeof(T).Name)
                {
                    case "List`1":
                        if (typeof(T).FullName == typeof(List<Champion>).FullName)
                            return JObject.Parse(retorno).Root["champions"].ToObject<T>();
                        else if (typeof(T).FullName == typeof(List<ChampionMastery>).FullName)
                            return JArray.Parse(retorno).ToObject<T>();
                        else
                            return null;
                    default:
                        return JObject.Parse(retorno).Root.ToObject<T>();
                }
            }
        }
    }
}
