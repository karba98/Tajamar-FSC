using Amazon.SQS;
using Microsoft.Extensions.DependencyInjection;
using Receiver.Models;
using Receiver.Services;
using System;
using System.Collections.Generic;

namespace Receiver
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var serviceprovider = new ServiceCollection()
                .AddAWSService<IAmazonSQS>()
                .AddTransient<ServiceSQS>()
                .BuildServiceProvider();
            var service = serviceprovider.GetService<ServiceSQS>();
            List<MensajeUsuario> mensajes = await service.GetMensajesAsync();
            if(mensajes == null)
            {

            }
            else
            {
                foreach(MensajeUsuario mensaje in mensajes)
                {
                    Console.WriteLine("- Asunto: " + mensaje.Asunto + "\n");
                    Console.WriteLine("- Mensaje " + mensaje.Mensaje);
                    Console.WriteLine("----------------------------");
                }
                Console.WriteLine("¿Desea eliminar todos los mensajes?");
                String respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "y")
                {
                    bool dato = await service.DeletemessageAsync();
                    if(dato == true)
                    {
                        Console.WriteLine("Mensajes Eliminados");
                    }
                }
                else
                {
                    Console.WriteLine("De acuerdo, pase un buen dia!");
                }
            }
        }
    }
}
