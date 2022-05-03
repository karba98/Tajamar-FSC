using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MVCCoreStorageFile.Services
{
    public class ServiceQueueBus
    {
        private ServiceBusClient client;
        public List<String> mensajes;
        public ServiceQueueBus(String keys)
        {
            this.mensajes = new List<string>();
            this.client = new ServiceBusClient(keys);
        }
        public async Task SendMessage(String data)
        {
            ServiceBusSender sender = client.CreateSender("colamensajes");
            ServiceBusMessage mensaje = new ServiceBusMessage(data);
            await sender.SendMessageAsync(mensaje);

        }
        private Queue<ServiceBusMessage> CreateMensajes()
        {
            Queue<ServiceBusMessage> mensajes = new Queue<ServiceBusMessage>();
            mensajes.Enqueue(new ServiceBusMessage("Primer mensaje"));
            mensajes.Enqueue(new ServiceBusMessage("Segundo mensaje"));
            mensajes.Enqueue(new ServiceBusMessage("Tercer mensaje"));
            mensajes.Enqueue(new ServiceBusMessage("Cuarto mensaje"));
            mensajes.Enqueue(new ServiceBusMessage("Se acabó la cola de mensajes"));
            return mensajes;
        }
        public async Task SendBachMessages()
        {
            ServiceBusSender sender = client.CreateSender("colamensajes");
            Queue<ServiceBusMessage> colamensajes = CreateMensajes();
            while (colamensajes.Count > 0)
            {
                ServiceBusMessageBatch batch = await sender.CreateMessageBatchAsync();
                if (batch.TryAddMessage(colamensajes.Peek()))
                {
                    colamensajes.Dequeue();
                }
                await sender.SendMessagesAsync(batch);
            }
        }
        public async Task<List<String>> RecibirMensajes()
        {
            ServiceBusProcessor procesador = client.CreateProcessor("colamensajes");
            
            procesador.ProcessMessageAsync += MessageHandler;
            procesador.ProcessErrorAsync += Procesador_ProcessErrorAsync;
            await procesador.StartProcessingAsync();
            //await procesador.StopProcessingAsync();
            return mensajes;
            

           
        }

        private Task Procesador_ProcessErrorAsync(ProcessErrorEventArgs arg)
        {
            return Task.CompletedTask;
        }

        private async Task MessageHandler(ProcessMessageEventArgs e)
        {
            
            String data = e.Message.Body.ToString();
            mensajes.Add(data);
            //USAR SESSION O UN WEB WORKER
            await e.CompleteMessageAsync(e.Message);
        }
    }
}
