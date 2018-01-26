using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RiotApi.Champion_Mastery;
using RiotApi.League;

namespace RiotApi.Some_Logic
{
    public static class HttpExecute
    {
        public static async Task<object> Execute<T>(string uri, string parammeters = "")
        {
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
               string retorno = null;
                response = await client.GetAsync(string.Format("{0}{1}?api_key={2}{3}", StaticData.BaseUrl, uri, StaticData.APIKey, parammeters));

                if (response.IsSuccessStatusCode)
                    retorno = await response.Content.ReadAsStringAsync();
                if (retorno == null)
                    return null;

                switch (typeof(T).Name)
                {
                    case "List`1":
                        if (typeof(T).FullName == typeof(List<Champion.Champion>).FullName)
                            return JObject.Parse(retorno).Root["champions"].ToObject<T>();
                        else if (typeof(T).FullName == typeof(List<ChampionMastery>).FullName || typeof(T).FullName == typeof(List<SummonerLeague>).FullName)
                            return JArray.Parse(retorno).ToObject<T>();
                        else
                            return null;
                    case nameof(Int32):
                        int result = 0;
                        return int.TryParse(retorno, out result) ? result : 0;
                    default:
                        return JObject.Parse(retorno).Root.ToObject<T>();
                }
            }
        }
    }
}
