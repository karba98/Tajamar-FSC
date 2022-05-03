
using Newtonsoft.Json;
using PracticaAzureMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAzureMVC.Services
{
    public class ServiceSeries
    {
        private String url;
        MediaTypeWithQualityHeaderValue header;
        public ServiceSeries(String url)
        {
            this.url = url;
            this.header = new MediaTypeWithQualityHeaderValue("application/json");
        }
        public async Task<List<Serie>> GetSeriesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/series/ListaSeries";
                return await CallApi<List<Serie>>(request);
            }
        }
        public async Task<List<Personaje>> GetPersonajesSerieAsync(int id)
        {
            String request = "api/Series/ListapersonajesSerie/" + id;
            return await CallApi<List<Personaje>>(request);
        }
        public async Task<Personaje>GetPersonajeAsync(int id)
        {
            String request = "api/series/personajes/" + id;
            return await CallApi<Personaje>(request);
        }
        public async Task<Serie>GetSerieAsync(int id)
        {
            String request = "api/series/" + id;
            return await CallApi<Serie>(request);
        }

        public async Task ModificarPersonajeAsync(int id, String nombre,String imagen, int idserie)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/series/modificarpersonaje";
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);

                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(header);
                //client.DefaultRequestHeaders.Add("Authorization"
                //    , "bearer " + token);

                Personaje person = new Personaje
                {
                    IdPersonaje = id,
                    Nombre = nombre,
                    Imagen = imagen,
                    IdSerie = idserie
                };
                String json = JsonConvert.SerializeObject(person);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PutAsync(request, content);
            }
        }

        public async Task InsertarPersonajeAsync( String nombre, String imagen,int idSerie)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/series/nuevopersonaje";
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);

                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(header);
                //client.DefaultRequestHeaders.Add("Authorization"
                //    , "bearer " + token);

                Personaje person = new Personaje
                {
                    IdPersonaje = 0,
                    Nombre = nombre,
                    Imagen = imagen,
                    IdSerie = idSerie
                };
                String json = JsonConvert.SerializeObject(person);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(request, content);
            }
        }

        private async Task<T> CallApi<T>(String request)
        {
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(this.url);
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
