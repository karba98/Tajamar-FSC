using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceWIlsonInformer.Models
{
    [Table("users")]
    public class Usuario
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("Nombre")]
        public String Nombre { get; set; }
        [Column("Apellido")]
        public String Apellido { get; set; }
        [Column("Email")]
        public String Email { get; set; }
        [Column("Username")]
        public String User { get; set; }
        [Column("Password")]
        public byte[] Pass { get; set; }
        [Column("Salt")]
        public String Salt { get; set; }
        [Column("ROL")]
        public String Rol { get; set; }
    }
}
