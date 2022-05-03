using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
namespace FunctionLikeEmpleado
{
    public static class Function1
    {
        [FunctionName("functionlikeemp")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log,
            ExecutionContext context)
        {
            log.LogInformation("C# HTTP trigger para like empleado.");

            string empno = req.Query["empno"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            empno = empno ?? data?.name;

            if (empno == null)
            {
                return new BadRequestObjectResult("Necesitamos {empno}");
            }

            var config = new ConfigurationBuilder()
                .SetBasePath(context.FunctionAppDirectory)
                .AddJsonFile("local.settings.json",optional:true,reloadOnChange:true)
                .AddEnvironmentVariables()
                .Build();

            String cadena = config.GetConnectionString("cadenahospital");
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                string sqlselect = "select * from emp where emp_no =" + empno;
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandType = System.Data.CommandType.Text;
                com.CommandText = sqlselect;
                cn.Open();
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    String mensaje = "El empleado " + reader["Apellido"] + "" +
                        " ha sido recompensado con 1€ extra en su sueldo " +
                        "Nescafe";
                    reader.Close();
                    String sqlupdate = "update emp set salario  = salario + 1 " +
                        "where emp_no=" + empno;
                    com.CommandText = sqlupdate;
                    com.ExecuteNonQuery();
                    cn.Close();
                    log.LogInformation(mensaje);
                    return new OkObjectResult(mensaje);

                }
                else
                {
                    reader.Close();
                    cn.Close();
                    return new BadRequestObjectResult("No existe el empleado " + empno);
                }
            }
            return new OkObjectResult("");
        }
       
    }
    
}
