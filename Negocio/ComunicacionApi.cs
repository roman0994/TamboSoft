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

                HttpResponseMessage response = null;

                var client = new HttpClient();
                //var contentjson = JsonConvert.SerializeObject(objettosend);
                //var buffer = Encoding.UTF8.GetBytes(contentjson);
                //var rawcontent = new ByteArrayContent(buffer);
                //rawcontent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                //var response = await client.PostAsync(url, rawcontent);

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
    }
}
