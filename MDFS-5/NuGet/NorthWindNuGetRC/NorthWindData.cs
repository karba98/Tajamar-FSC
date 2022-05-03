using Newtonsoft.Json;
using NorthWindNuGetRC.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindNuGetRC
{
    public class NorthWindData
    {
        public async Task<CustomerList> GetCustomersList()
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            String url = "https://services.odata.org/V4/Northwind/Northwind.svc/Customers";
            String datajson = await client.DownloadStringTaskAsync(url);
            CustomerList customers = JsonConvert.DeserializeObject<CustomerList>(datajson);
            return customers;
        }
        public async Task<CustomerNode> GetCustomer(String id)
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            String url = "http://northwind.netcore.io/customers/"+id+"?format=json";
            String datajson = await client.DownloadStringTaskAsync(url);
            CustomerNode customer = JsonConvert.DeserializeObject<CustomerNode>(datajson);
            return customer;
        }
    }
}
