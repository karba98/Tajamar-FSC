using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NugetDoctoresModelsRC
{
    [Table("DOCTOR")]
    public class Doctor
    {
        [Key]
        [Column("DOCTOR_NO")]
        public int IdDoctor { get; set; }
        [Column("APELLIDO")]
        public String Apellido{ get; set; }
        [Column("ESPECIALIDAD")]
        public String Especialidad{ get; set; }
        [Column("HOSPITAL_COD")]
        public int HospitalCod{ get; set; }
        [Column("SALARIO")]
        public int Salario{ get; set; }
    }
}
