using Microsoft.Azure.Cosmos.Table;
using MVCCoreStorageFile.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MVCCoreStorageFile.Services
{
    public class ServiceTableAlumnos
    {
        public async Task<String> GetTokenAsync(String curso)
        {
            String request = "api/access/Token/" + curso;
            String url = "https://localhost:44368/";
            using (WebClient client = new WebClient())
            {
                client.Headers["content-type"] = "application/json";
                Uri uriapi = new Uri(url + request);
                String content = await client.DownloadStringTaskAsync(uriapi);
                JObject jobject = JObject.Parse(content);
                return jobject.GetValue("token").ToString();
            } 
        }
        public List<Alumno> GetAlumnos(String token)
        {
            String uriStirage = "http://127.0.0.1:10002/devstoreaccount1/";
            StorageCredentials credenciales = new StorageCredentials(token);
            CloudTableClient client = new CloudTableClient(new Uri(uriStirage), credenciales);
            CloudTable tablaalumnos = client.GetTableReference("tablaalumnos");
            TableQuery<Alumno> query = new TableQuery<Alumno>();
            return tablaalumnos.ExecuteQuery(query).ToList();
            
        }
    }
}
