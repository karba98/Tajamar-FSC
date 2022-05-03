using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindNuGetRC.Models
{
    public  class CustomerList
    {
        [JsonProperty("value")]
        public List<Customer> values { get; set; }
    }
}
