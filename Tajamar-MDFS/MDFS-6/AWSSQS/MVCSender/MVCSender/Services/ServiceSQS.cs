using Amazon.SQS;
using Amazon.SQS.Model;
using Microsoft.Extensions.Configuration;
using MVCSender.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSender.Services
{
    public class ServiceSQS
    {
        private IAmazonSQS client;
        private String queueUrl;
        public ServiceSQS(IAmazonSQS client, IConfiguration config)
        {
            queueUrl = config["AWS:QueueUrl"];
            this.client = client;
        }
        public async Task<bool> SendMessageAsync(MensajeUsuario mensaje)
        {
            String data = JsonConvert.SerializeObject(mensaje);
            SendMessageRequest request = new SendMessageRequest(queueUrl,data);
            SendMessageResponse response = await client.SendMessageAsync(request);
            if (response.HttpStatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else return false;
        }
    }
}
