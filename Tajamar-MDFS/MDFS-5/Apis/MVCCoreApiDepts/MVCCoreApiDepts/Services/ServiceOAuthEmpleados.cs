using MVCCoreApiDepts.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreApiDepts.Services
{
    public class ServiceOAuthEmpleados
    {
        private Uri Uriapi;
        private MediaTypeWithQualityHeaderValue Header;
        public ServiceOAuthEmpleados(String url)
        {
            Uriapi = new Uri(url);
            Header = new MediaTypeWithQualityHeaderValue("application/json");
        }
        public async Task<String> GetToken(String username, String password)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = Uriapi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(Header);
                LoginModel login = new LoginModel()
                {
                    UserName=username,
                    Password=password
                };
                String json = JsonConvert.SerializeObject(login);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                String request = "auth/login";
                HttpResponseMessage response = await client.PostAsync(request,content);
                if (response.IsSuccessStatusCode)
                {
                    String data = await response.Content.ReadAsStringAsync();
                    JObject obj = JObject.Parse(data);
                    String token = obj.GetValue("response").ToString();
                    return token;

                }
                else return null;

            }
        }
        private async Task<T> CallAPi<T>(String request)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = Uriapi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(Header);
                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    T data = await response.Content.ReadAsAsync<T>();
                    return data;

                }
                else return default(T);


            }
        }
        private async Task<T> CallAPi<T>(String request,String token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = Uriapi;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(Header);
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + token);

                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    T data = await response.Content.ReadAsAsync<T>();
                    return data;

                }
                else return default(T);


            }
        }
        public async Task<Empleado> BuscarEmpleadoAsync(int idEmpleado)
        {
            String request = "api/empleados/" + idEmpleado;
            Empleado emp = await CallAPi<Empleado>(request);
            return emp;
        }
        public async Task<List<Empleado>> GetSubordinados(String token)
        {
            String request = "api/empleados/subordinados";
            List<Empleado> empleados = await CallAPi<List<Empleado>>(request,token);
            return empleados;
        }
        public async Task<Empleado> GetPerfil(String token)
        {
            String request = "api/empleados/profile";
            Empleado perfil = await CallAPi<Empleado>(request,token);
            return perfil;
        }
    }
}
