using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.ExchangeActiveSyncProvisioning;
using Newtonsoft.Json;

namespace FedtFitness.Persistency
{
    class GenericFedtWebAPI<T> where T:class
    {

        public static List<T> getAll(string url)
        {
            const string serverURL = "http://localhost:63830/";
            HttpClientHandler handler =  new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            using (HttpClient client =  new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverURL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var response = client.GetAsync(url).Result;
                    response.EnsureSuccessStatusCode();
                    string data = response.Content.ReadAsStringAsync().Result;
                    List<T> gList = JsonConvert.DeserializeObject<List<T>>(data);
                    return gList;
                }
                catch
                {
                    return new List<T>();
                }
            }

        }



    }
}
