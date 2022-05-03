using APIPersonajesRC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIPersonajesRC
{
    public class ApiPersonsajes
    {
        public async Task<List<Personaje>> GetPersonajes()
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            String url = "https://apiseriespersonajes.azurewebsites.net/api/Personajes";
            String datajson =
                await client.DownloadStringTaskAsync(url);
            List<Personaje> personajes =
                JsonConvert.DeserializeObject<List<Personaje>>(datajson);
            return personajes;

        }
        public async Task<Personaje> GetPersonaje(int id)
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            String url = "https://apiseriespersonajes.azurewebsites.net/api/Personajes/"+id;
            String datajson =
                await client.DownloadStringTaskAsync(url);
            Personaje personaje =
                JsonConvert.DeserializeObject<Personaje>(datajson);
            return personaje;
        }
    }
}
