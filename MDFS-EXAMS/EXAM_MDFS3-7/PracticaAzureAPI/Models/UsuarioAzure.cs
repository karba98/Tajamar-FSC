using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaAzureAPI.Models
{
    [Table("USUARIOSAZURE")]
    public class UsuarioAzure
    {
        [Key]
        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }
        [Column("NOMBRE")]
        public String Nombre { get; set; }
        [Column("APELLIDOS")]
        public String Apellidos { get; set; }
        [Column("EMAIl")]
        public String Email { get; set; }
        [Column("PASS")]
        public String Pass { get; set; }
    }
}
