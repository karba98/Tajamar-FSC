using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceRandomNumbers;
namespace ClienteWCFCore.Services
{
    public class WCF_Azure_ServiceRandomNumber
    {
        ServiceRandomNumbersClient client;
        public WCF_Azure_ServiceRandomNumber()
        {
            this.client = new ServiceRandomNumbersClient();
        }
        public async Task<List<int>> GetRandomNumbers()
        {
            int[] numeros = await client.GetRandomNumbersAsync();
            return numeros.ToList();
        }

    }
}
