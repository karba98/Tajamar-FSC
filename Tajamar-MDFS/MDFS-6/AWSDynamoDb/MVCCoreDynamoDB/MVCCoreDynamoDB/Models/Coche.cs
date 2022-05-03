using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreDynamoDB.Models
{
    [DynamoDBTable("coches")]
    public class Coche
    {
        [DynamoDBProperty("idcoche")]
        [DynamoDBHashKey]
        public int IdCoche { get; set; }
        [DynamoDBProperty("marca")]
        public String Marca { get; set; }
        [DynamoDBProperty("modelo")]
        public String Modelo { get; set; }
        [DynamoDBProperty("velocidad-max")]
        public int VMaxima { get; set; }
        [DynamoDBProperty("motor")]
        public Motor Motor { get; set; }
    }
}
