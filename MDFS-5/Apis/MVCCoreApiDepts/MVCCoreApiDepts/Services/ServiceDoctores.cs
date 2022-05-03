using Newtonsoft.Json;
using NugetDoctoresModelsRC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ToolKitJuniorNet;
namespace MVCCoreApiDepts.Services
{
    public class ServiceDoctores
    {
        private Uri uri;
        private MediaTypeWithQualityHeaderValue header;

        private ServiceApiToolsJSON toolkit;
        public ServiceDoctores(String url)
        {
            toolkit = new ServiceApiToolsJSON();

            this.uri = new Uri(url);
            header = new MediaTypeWithQualityHeaderValue("application/json");
        }
        public async Task<List<Doctor>> GetDoctores()
        {
            String request = "api/doctores";

            //return await toolkit.CallApiGET<List<Doctor>>(uri, request);
            return await CallApi<List<Doctor>>(request);
        }
        public async Task<Doctor> GetDoctor(int id)
        {
            String request = "api/doctores/"+id;
            //return await toolkit.CallApiGET<Doctor>(uri, request);
            return await CallApi<Doctor>(request);
        }
        public async Task InsertDoctorAsync(int id, String apellido, String especialidad, int hospital, int salario)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/doctores";
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);

                String json = GetDoctorJson(id, apellido, especialidad, hospital, salario);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(request,content);
            }
        }
        public async Task UpdateDoctorAsync(int id, String apellido, String especialidad, int hospital, int salario)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/doctores";
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);

                String json = GetDoctorJson(id, apellido, especialidad, hospital, salario);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                await client.PutAsync(request, content);
            }
        }
        public async Task DeleteDoctorAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/doctores/"+id;
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);

                await client.DeleteAsync(request);
            }
        }
        public async Task IncrementoSalarioHospitalAsync(int incremento, int hospitalcod)
        {
            using (HttpClient client = new HttpClient())
            {
                String request = "api/doctores/incrementarsalario/" + incremento+"/"+hospitalcod;
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);


                //StringContent("") ya que es un put pero en body no metemos ningun json
                await client.PutAsync(request,new StringContent(""));
            }
        }
        public async Task<List<String>> GetEspecialidadesAsync()
        {
            String request = "api/doctores";
            return await  CallApi<List<String>>(request+"/especialidades");
        }
        public async Task<List<Doctor>> GetDoctoresEspecialidadesAsync(List<String> especialidades)
        {
            String request = "api/doctores/porespecialidades?";
            String data = "";
            foreach(String s in especialidades)
            {
                data += "especialidades="+ s + "&";
            }
            data = data.Trim('&');
            return await CallApi<List<Doctor>>(request + data);
        }

        //--------------------------------------------------------------------------------------------------------------


        private String GetDoctorJson(int id, String apellido,String especialidad,int hospital, int salario) 
        {
            Doctor doc = new Doctor
            {
                IdDoctor = id,
                Apellido = apellido,
                Especialidad = especialidad,
                HospitalCod = hospital,
                Salario = salario
            };
            return JsonConvert.SerializeObject(doc);
            //return ToolKitJuniorNet.ServiceText.Serialize(doc);
        }

        private async Task<T> CallApi<T>(String request)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = this.uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(header);
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
