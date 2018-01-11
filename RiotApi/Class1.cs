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
        public static async Task<string> Execute(string uri)
        {
            HttpResponseMessage response;
            using (HttpClient client = new HttpClient())
            {
                response = await client.GetAsync(string.Format("{0}{1}{2}", StaticData.BaseUrl, uri, StaticData.APIKey));
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadAsStringAsync();
            }
            return null;
        }
    }
}
