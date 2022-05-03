using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindNuGetRC.Models
{
    public class Customer
    {
        [JsonProperty("CustomerID")]
        public String CustomerID { get; set; }
        [JsonProperty("CompanyName")]
        public String ComapnyName { get; set; }
        [JsonProperty("ContactName")]
        public String Name { get; set; }
        [JsonProperty("Address")]
        public String Address { get; set; }
        [JsonProperty("City")]
        public String City { get; set; }
        [JsonProperty("Phone")]
        public String Phone { get; set; }
    }
}
