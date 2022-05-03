using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WilsonInformer.Models;

namespace WilsonInformer.Services
{
    public class ServicePartes 
    {
        Uri uri;
        private MediaTypeWithQualityHeaderValue header;
        public ServicePartes(String url)
        {
            this.uri = new Uri(url);
            this.header = new MediaTypeWithQualityHeaderValue("application/json");

        }
        public async Task<T> CallApi<T>(String request,String token)
        {
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.header);
                client.DefaultRequestHeaders.Add("Authorization"
                   , "bearer " + token);
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
        public async Task ClearDB(String token)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/Partes/clear";
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.header);
                client.DefaultRequestHeaders.Add("Authorization"
                  , "bearer " + token);
                await client.PostAsync(request, null);
            }
        }

        public async Task<Dictionary<string, int>> GetAbonados(String token)
        {
            String request = "api/Partes/abonados";
            Dictionary<string, int> abonados = await this.CallApi<Dictionary<string, int>>(request,token);
            return abonados;
        }

        public async Task<Dictionary<string, int>> GetEstados(String token)
        {
            String request = "api/Partes/estados";
            Dictionary<string, int> estados = await this.CallApi<Dictionary<string, int>>(request,token);
            return estados;
        }

        public async Task<Dictionary<string, int>> GetFramquiciasDestino(String token)
        {
            String request = "api/Partes/franquicias/destino";
            Dictionary<string, int> fdest = await this.CallApi<Dictionary<string, int>>(request,token);
            return fdest;
        }

        public async Task<Dictionary<string, int>> GetFramquiciasOrigen(String token)
        {
            String request = "api/Partes/franquicias/origen";
            Dictionary<string, int> forig = await this.CallApi<Dictionary<string, int>>(request,token);
            return forig;
        }

        public async Task<int> GetNumPartesCerradosSinF(String token)
        {
            String request = "api/Partes/cerrados/numero";
            int cerradossinf = await this.CallApi<int>(request,token);
            return cerradossinf;
        }

        public async Task<Parte> GetParte(string nparte,String token)
        {
            String request = "api/Partes/"+nparte;
            Parte parte = await this.CallApi<Parte>(request,token);
            return parte;
        }

        public async Task<List<Parte>> GetPartesCerrados(String token)
        {
            String request = "api/Partes/cerrados";
            List<Parte> cerrados = await this.CallApi<List<Parte>>(request,token);
            return cerrados;
        }

        public async Task<List<Parte>> GetPartesDB(String token)
        {
            String request = "api/Partes";
            List<Parte> partes = await this.CallApi<List<Parte>>(request,token);
            return partes;
        }

        public async Task<List<Parte>> GetPartesDBAlbaranParte(string albaran, string parte,String token)
        {
            if(parte== "" || parte == null) { parte = "0"; }
            if(albaran== "" || albaran == null) { albaran = "0"; }

            String request = "api/Partes/" + albaran+"/"+parte;
            List<Parte> partes = await this.CallApi<List<Parte>>(request,token);
            return partes;
        }

        public async Task <List<Parte>> GetPartesEntregadosEnGestion(String token)
        {
            String request = "api/Partes/entregadosengestion";
            List<Parte> partes = await this.CallApi<List<Parte>>(request,token);
            return partes; 
        }

        public async Task<List<Parte>> GetPartesFecha(DateTime dateTo, DateTime dateFrom, List<Parte> listafilter,String token)
        {
            String request = "api/Partes/fechas";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.header);
                client.DefaultRequestHeaders.Add("Authorization"
                  , "bearer " + token);
                DateFinder dates = new DateFinder
                {
                    dateFrom = dateFrom,
                    dateTo = dateTo,
                    listafilter = listafilter
                };
                String json = JsonConvert.SerializeObject(dates);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response =await client.PostAsync(request,content);
                if (response.IsSuccessStatusCode)
                {
                    List<Parte> data = await response.Content.ReadAsAsync<List<Parte>>();
                    return data;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Parte>> GetPartesPendientes15(String token)
        {
            String request = "api/Partes/pendientes15";
            List<Parte> partes = await this.CallApi<List<Parte>>(request,token);
            return partes;
        }

        public async Task<Dictionary<string, int>> GetPropis(String token)
        {
            String request = "api/Partes/propis";
            Dictionary<string, int> partes = await this.CallApi<Dictionary<string, int>>(request,token);
            return partes;
        }

        public async Task<int> InsertListaPartes(List<Parte> partes,String token)
        {
            String request = "api/Partes";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.header);
                client.DefaultRequestHeaders.Add("Authorization"
                  , "bearer " + token);
                String json = JsonConvert.SerializeObject(partes);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(request, content);
                if (response.IsSuccessStatusCode)
                {
                    int data = await response.Content.ReadAsAsync<int>();
                    return data;
                }
                else
                {
                    return 0;
                }
            }
        }

        public async Task<Dictionary<string, int>> SetPartesFechaGraphicData(List<Parte> partesFecha,String token)
        {
            String request = "api/Partes/partesporfecha";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.header);
                client.DefaultRequestHeaders.Add("Authorization"
                  , "bearer " + token);
                String json = JsonConvert.SerializeObject(partesFecha);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(request, content);
                if (response.IsSuccessStatusCode)
                {
                    Dictionary<string,int> data = await response.Content.ReadAsAsync<Dictionary<string,int>>();
                    return data;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
