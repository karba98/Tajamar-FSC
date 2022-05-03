using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctores.Models
{
    [Table("Doctor")]
    public class Doctor
    {
        [Column("HOSPITAL_COD")]
        public int HospitalCod { get; set; }
        [Column("Apellido")]
        public String Apellido { get; set; }
        [Key]
        [Column("DOCTOR_NO")]
        public int DoctorNo { get; set; }
        [Column("ESPECIALIDAD")]
        public String Especialidad { get; set; }
        [Column("SALARIO")]
        public int Salario { get; set; }

    }
}
