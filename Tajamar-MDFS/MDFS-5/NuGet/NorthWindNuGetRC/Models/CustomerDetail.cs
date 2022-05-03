using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindNuGetRC.Models
{
    public class CustomerDetail
    {
            [JsonProperty("id")]
            public String CustomerID { get; set; }
            [JsonProperty("companyname")]
            public String ComapnyName { get; set; }
            [JsonProperty("contactName")]
            public String Name { get; set; }
            [JsonProperty("contactTitle")]
            public String Title { get; set; }
            [JsonProperty("address")]
            public String Address { get; set; }
            [JsonProperty("city")]
            public String City { get; set; }
            [JsonProperty("phone")]
            public String Phone { get; set; }
        
    }
    public class CustomerNode
    {
        [JsonProperty("customer")]
        public CustomerDetail customer { get; set; }
    }
}
