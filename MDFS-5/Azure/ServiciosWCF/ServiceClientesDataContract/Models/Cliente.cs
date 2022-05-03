using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientesDataContract.Models
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IdCliente { get; set; }
        [DataMember]
        public String Nombre { get; set; }
        [DataMember]
        public String Email { get; set; }
        [DataMember]
        public String ImagenCliente { get; set; }
    }
}
