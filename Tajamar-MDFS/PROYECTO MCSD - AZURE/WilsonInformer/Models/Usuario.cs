using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WilsonInformer.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String User { get; set; }
        public byte[] Pass { get; set; }
        public String Salt { get; set; }
        public String Rol { get; set; }
        public String Token { get; set; }
    }
}
