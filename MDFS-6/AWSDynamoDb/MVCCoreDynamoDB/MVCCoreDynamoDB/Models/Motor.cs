using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreDynamoDB.Models
{
    public class Motor
    {
        [DynamoDBProperty("tipo")]
        public String Tipo { get; set; }
        [DynamoDBProperty("caballos")]
        public int Caballos { get; set; }
        [DynamoDBProperty("cilindrada")]
        public int Cilindrada { get; set; }
    }
}
