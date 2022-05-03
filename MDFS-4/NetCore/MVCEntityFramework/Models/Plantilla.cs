using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Models
{
    [Table("PLANTILLA")]
    public class Plantilla
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("HOSPITAL_COD")]
        public String HospitalCOD { get; set; }
        [Column("SALA_COD")]
        public String SalaCOD { get; set; }
        [Column("EMPLEADO_NO")]
        public String EmpleadoN { get; set; }
        [Column("APELLIDO")]
        public String Apellido { get; set; }
        [Column("FUNCION")]
        public String Funcion { get; set; }
        [Column("T")]
        public String T { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }
    }
}
