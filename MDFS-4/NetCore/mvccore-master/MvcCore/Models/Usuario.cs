using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Models
{
    [Table("USERHASH")]
    public class Usuario
    {
        [Column("IDUSUARIO")]
        public int Id { get; set; }
        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("USUARIO")]
        public String User { get; set; }
        [Column("PASS")]
        public byte[] Pass { get; set; }
        [Column("SALT")]
        public String Salt { get; set; }
    }
}
