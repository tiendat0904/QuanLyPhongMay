using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Common.Common
{
    public static class HttpUtilities
    {
        public static async Task<T> GetAsyncApi<T>(string url, string token = null) where T : new()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    
                    httpClient.BaseAddress = new Uri(url);
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                    HttpResponseMessage respone = httpClient.GetAsync(url).Result;
                    if (respone.IsSuccessStatusCode)
                    {
                        var responeContent = respone.Content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<T>(responeContent);
                    }
                    else
                    {
                        return new T();
                    }

                }
            }catch(Exception ex)
            {
                return new T();
                // ghi log
            }
        }

        public static async Task<T> PostAsyncApi<T>(string url, string data, string token = null) where T : new()
        {
            using(HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(url);
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                if (string.IsNullOrEmpty(data))
                {
                    data = string.Empty;
                }

                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var respone = httpClient.PostAsync(url, content).Result;
                if (respone.IsSuccessStatusCode)
                {
                    var result = respone.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<T>(result);
                }
                else
                {
                    return new T();
                }
            }
        }
    }
}
