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
        HttpClientHandler handler;
        HttpClient client;
        string _url;
        const string serverURL = "http://localhost:63830/";
        public GenericFedtWebAPI(string url)
        {
            handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true; 
            client = new HttpClient(handler);
            client.BaseAddress = new Uri(serverURL);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _url = url;
        }

        public List<T> getAll()
        {

           
            

                try
                {
                    var response = client.GetAsync(_url).Result;
                    response.EnsureSuccessStatusCode();
                    string data = response.Content.ReadAsStringAsync().Result;
                    List<T> cList = JsonConvert.DeserializeObject<List<T>>(data);
                    return cList;
                }
                catch (Exception ex)
                {
                    return new List<T>();
                }
            

        }

        public async void createNewOne(T obj)
        {
            
                try
                {
                    string data = JsonConvert.SerializeObject(obj);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(_url, content);
                    response.EnsureSuccessStatusCode();
                }
                catch (Exception ex)
                {
                   Console.WriteLine(ex.Message);
                }
          
        }


    }
}
