using Amazon.SQS;
using Amazon.SQS.Model;
using Newtonsoft.Json;
using Receiver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver.Services
{
    public class ServiceSQS
    {
        public IAmazonSQS client;
        private String queueUrl;
        public ServiceSQS(IAmazonSQS client)
        {
            this.client = client;
            queueUrl = "https://sqs.eu-west-2.amazonaws.com/390064371148/queue-consultas-usuarios-rcdlt";   
        }
        public async Task<List<MensajeUsuario>> GetMensajesAsync()
        {
            ReceiveMessageRequest request = new ReceiveMessageRequest()
            {
                QueueUrl = queueUrl,
                MaxNumberOfMessages = 10,
                WaitTimeSeconds = 5
                
            };
            ReceiveMessageResponse response = await this.client.ReceiveMessageAsync(request);
            if(response.HttpStatusCode == System.Net.HttpStatusCode.OK)
            {
                if (response.Messages.Count == 0)
                {
                    return null;
                }
                else
                {
                    List<Message> messages = response.Messages;
                    List<MensajeUsuario> mensajes = messages.Select(x =>
                        JsonConvert.DeserializeObject<MensajeUsuario>(x.Body))
                        .ToList();
                    return mensajes;
                }
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> DeletemessageAsync()
        {
            DeleteMessageRequest request = new DeleteMessageRequest()
            {
                QueueUrl = queueUrl
            };
            DeleteMessageResponse response = await this.client.DeleteMessageAsync(request);
            if(response.HttpStatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
