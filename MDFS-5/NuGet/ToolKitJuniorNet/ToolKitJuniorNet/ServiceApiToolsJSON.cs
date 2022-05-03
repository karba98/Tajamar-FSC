using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ToolKitJuniorNet
{
    public class ServiceApiToolsJSON
    {
         private MediaTypeWithQualityHeaderValue header;
         public ServiceApiToolsJSON()
         {
            this.header = new MediaTypeWithQualityHeaderValue("application/json");
        }
         public async Task<T> CallApiGET<T>(Uri baseUrl, String request)
         {
            using (HttpClient client = new HttpClient())
            {
                
                client.BaseAddress = baseUrl;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.header);
                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    T data = await response.Content.ReadAsAsync<T>();
                    return data;
                }
                else
                {
                    return default(T);
                }
            }
        }
         
    }
}
