using MVCCoreApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MVCCoreApis.Services
{
    public class ServiceApiDoctores
    {
        private String url;
        MediaTypeWithQualityHeaderValue header;
        public ServiceApiDoctores(String url)
        {
            this.url = url;
            this.header = new MediaTypeWithQualityHeaderValue("application/json");
        }
        public async Task<List<Doctor>> GetDoctoresAsync()
        {
            //using para liberar todas las acciones
            using (HttpClient client = new HttpClient())
            {
                String request = "api/doctores";
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    List<Doctor> doctores = await response.Content.ReadAsAsync<List<Doctor>>();
                    return doctores;
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<List<String>> GetEspecialidadesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/doctores/especialidades";
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    List<String> especialidades = await response.Content.ReadAsAsync<List<String>>();
                    return especialidades;
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<List<Doctor>> GetDoctoresEspecialidadAsync(String especialidad)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/doctores/especialidad/" + especialidad;
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                HttpResponseMessage response = await client.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    List<Doctor> doctores = await response.Content.ReadAsAsync<List<Doctor>>();
                    return doctores;

                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<Doctor> GetDoctor(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/doctores/"+id.ToString();
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
                HttpResponseMessage response = await client.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    Doctor doctor = await response.Content.ReadAsAsync<Doctor>();
                    return doctor;

                }
                else
                {
                    return null;
                }
            }
        }
    }
}

