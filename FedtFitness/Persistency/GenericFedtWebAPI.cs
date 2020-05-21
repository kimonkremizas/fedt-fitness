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
        private HttpClientHandler handler;
        private  HttpClient client;
        private  string _url;
        public GenericFedtWebAPI(string serverURL, string url)
        {
            handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            client = new HttpClient(handler);
            client.BaseAddress = new Uri(serverURL);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _url = url;
        }


        public async Task<List<T>> getAll()
        {
            //const string serverURL = "http://localhost:63830/";
            using (client)
            {
                
                try
                {
                    var response = await client.GetAsync(_url);
                    response.EnsureSuccessStatusCode();
                    string data = response.Content.ReadAsStringAsync().Result;
                    List<T> gList = JsonConvert.DeserializeObject<List<T>>(data);
                    return gList;
                }
                catch (Exception ex)
                {
                    return new List<T>();
                }
            }
        }

        public  async void createNewOne(T obj)
        {
            using (client)
            {

                try
                {
                    string data = JsonConvert.SerializeObject(obj);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(_url,content);
                    response.EnsureSuccessStatusCode();
                   
                }
                catch(Exception ex)
                {
                   Console.WriteLine(ex.Message);
                }
            }
        }



    }
}
