using MVCCoreApiDepts.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreApiDepts.Services
{
    public class ServiceDepartamentos
    {
        private Uri uri;
        private MediaTypeWithQualityHeaderValue header;
        public ServiceDepartamentos(String url) 
        {
            this.uri = new Uri(url);
            this.header = new MediaTypeWithQualityHeaderValue("application/json");

        }
        public async Task<List<Departamento>> GetDepartamentos()
        {
            //return await this.CallApi<List<Departamento>>("api/departamentos/");

            //PRUEBO MI NUGET TOOLKIT CON GET DE API
            ToolKitJuniorNet.ServiceApiToolsJSON toolkitServiceCaller= new ToolKitJuniorNet.ServiceApiToolsJSON();
            return await toolkitServiceCaller.CallApiGET<List<Departamento>>(uri, "api/departamentos");
        }
        public async Task<Departamento> BuscarDepartamentoAsync(int id)
        {
            return await this.CallApi<Departamento>("api/departamentos/" + id);
        }
            
        public async Task<T> CallApi<T>(String request)
        {
            using (HttpClient client = new HttpClient())
            {
                
                client.BaseAddress = this.uri;
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
        public async Task DeleteDepartamentoAsync(int id) 
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/departamentos/"+id.ToString();
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.header);
                await client.DeleteAsync(request);
            }
        }
        public async Task InsertarDepartamentoAsync(int id, String nombre, String localidad)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/departamentos";
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                Departamento dept = new Departamento
                {
                    Id=id,
                    Nombre = nombre,
                    Localidad = localidad
                };
                String json = JsonConvert.SerializeObject(dept);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(request, content);
            }
        }
        public async Task UpdateDepartamentoAsync(int id,String nombre,String localidad)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/departamentos";
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                Departamento dept = new Departamento
                {
                    Id=id,
                    Nombre = nombre,
                    Localidad = localidad
                };
                //PRUEBO USANDO MI TOOLKIT
                String json = ToolKitJuniorNet.ServiceText.Serialize(dept);
                //String json = JsonConvert.SerializeObject(dept);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PutAsync(request, content);
            }
        }
        
    }
}
