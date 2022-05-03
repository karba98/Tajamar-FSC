using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDoctoresSql.Models
{
    [DataContract]
    [Table("DOCTOR")]
    public class Doctor
    {
        [DataMember]
        [Column("DOCTOR_NO")]
        public int Id{ get; set; }
        [DataMember]
        [Column("APELLIDO")]
        public String Apellido { get; set; }
        [DataMember]
        [Column("ESPECIALIDAD")]
        public String Especialidad { get; set; }
    }
}
