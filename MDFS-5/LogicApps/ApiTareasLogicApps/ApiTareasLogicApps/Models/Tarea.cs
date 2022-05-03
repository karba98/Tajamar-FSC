using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTareasLogicApps.Models
{
    [Table("TAREASEMPLEADOS")]
    public class Tarea
    {
        [Key]
        [Column("IDTAREA")]
        public int Id { get; set; }
        [Column("NOMBRE")]
        public String Nombre{ get; set; }
        [Column("DESCRIPCION")]
        public String Descripcion{ get; set; }
        [Column("IDEMPLEADO")]
        public int IdEmpleado{ get; set; }
        [Column("ESTADO")]
        public String Estado{ get; set; }
    }
}
