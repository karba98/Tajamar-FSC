using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WilsonInformer.Helpers;
using WilsonInformer.Models;

namespace WilsonInformer.Services
{
    public class ServiceUsers
    {
        Uri uri;
        private MediaTypeWithQualityHeaderValue header;

        public ServiceUsers(String url)
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
        public async Task<bool> InsertUser(String nombre,
            String username,
            String password,
            String Apellido,
            String email,
            String Rol,
            String token,
            
            String emailfrom
            )
        {
            String salt = CypherService.GetSalt();
            byte[] pass = CypherService.Encrypt(password, salt);

            String request = "api/auth/insertuser";
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.header);

                client.DefaultRequestHeaders.Add("Authorization"
                    , "bearer " + token);

                Usuario user = new Usuario()
                {
                    Nombre = nombre,
                    Apellido = Apellido,
                    User = username,
                    Email = email,
                    Rol = Rol,
                    Salt = salt,
                    Pass = pass,
                    Id = 0
                };
                String json = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(request, content);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    using (HttpClient clientemail = new HttpClient())
                    {
                        String baseLAurl = "https://prod-11.southcentralus.logic.azure.com/";
                        clientemail.BaseAddress = new Uri(baseLAurl);
                            
                        clientemail.DefaultRequestHeaders.Accept.Clear();
                        clientemail.DefaultRequestHeaders.Accept.Add(this.header);
                        String request2 = "workflows/767828dd338a4440a09ae1636ff737a9/triggers/manual/paths/invoke/" + user.User + "/" +
                            "" + user.Email + "/" + emailfrom + "/" +token+
                            "?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=QJyGP7CMt9dg36VNesiAJRR8-tcvRUm4jeAjlQJY0ro";
                       
                        HttpResponseMessage responseemail = await clientemail.GetAsync(request2);
                        if (responseemail.IsSuccessStatusCode)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    
                }
                else
                {
                    return false;
                }
            }
        }
        public async Task<Usuario> Check(String username, String pass)
        {

            using (HttpClient client = new HttpClient())
            {
                //setup client
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                
                String json = JsonConvert.SerializeObject(new { Username = username, Password = pass});

                StringContent content =
                    new StringContent(json
                    , System.Text.Encoding.UTF8, "application/json");
                String peticion = "api/auth/Login";
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    String contenido =
                    await response.Content.ReadAsStringAsync();
                    var jObject = JObject.Parse(contenido);
                    var usuario = jObject.GetValue("user").ToString();
                    Usuario user = JsonConvert.DeserializeObject<Usuario>(usuario);
                    user.Token = jObject.GetValue("response").ToString();
                    return user;
                }
                else
                {
                    return null;
                }
                
            }
        }
        public async Task<bool> Exist(String username,String email,String token)
        {
            //No comprueba si existe el email, solo nombre de usuario
            return await CallApi<bool>("api/auth/exist/" + username+"/"+email,token);
        }

    }
}
