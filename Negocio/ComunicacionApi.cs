using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ComunicacionApi
    {
        public HttpResponseMessage response;
        public async Task<T> Get<T>(string Url)
        {

            try
            {
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(Url);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return default(T);


        }


        public async Task<K> Post<T, K>(string url, K objettosend)
        {

            try
            {
                var uri = new Uri(string.Format(url, string.Empty));


                var json = JsonConvert.SerializeObject(objettosend);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                response = null;

                var client = new HttpClient();
                

                response = await client.PostAsync(uri, content);

                if (response != null && response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();

                    return Newtonsoft.Json.JsonConvert.DeserializeObject<K>(jsonstring);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return default(K);
        }

        public async Task<K> Put<T, K>(string url, K objettosend)
        {

            try
            {
                var uri = new Uri(string.Format(url, string.Empty));


                var json = JsonConvert.SerializeObject(objettosend);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                response = null;

                var client = new HttpClient();

                response = await client.PutAsync(uri, content);


                if (response != null && response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();

                    return Newtonsoft.Json.JsonConvert.DeserializeObject<K>(jsonstring);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return default(K);
        }
    }
}
