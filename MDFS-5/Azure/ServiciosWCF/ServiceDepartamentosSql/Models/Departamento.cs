using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDepartamentosSql
{
    [DataContract]
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [Column("DEPT_NO")]
        [DataMember]
        public int IdDept { get; set; }
        [Column("DNOMBRE")]
        [DataMember]
        public String Nombre { get; set; }
        [Column("LOC")]
        [DataMember]
        public String Localidad { get; set; }
    }
}
