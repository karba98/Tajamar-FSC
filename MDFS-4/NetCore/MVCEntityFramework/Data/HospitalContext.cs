using Microsoft.EntityFrameworkCore;
using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace MVCEntityFramework.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options):base(options)
        {}
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Plantilla> Plantilla { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<EmpleadoHospital> EmpleadosHospital { get; set; }
        public DbSet<EmpleadoGenerico> EmpleadosGenerico  { get; set; }

        public void ModificarEspecialidad(int doctor, String espe)
        {
            String sql = "cambiarespecialidad @iddoctor, @especialidad";
            SqlParameter paramId = new SqlParameter("@iddoctor", doctor);
            SqlParameter paramEs = new SqlParameter("@especialidad", espe);
            this.Database.ExecuteSqlRaw(sql,paramId,paramEs);
        }
        public void ModificarSalarioEspecialidad(int incremento, String espe)
        {
            String sql = "MODIFICARSALARIOESP @incremento, @especialidad";
            SqlParameter paramEs = new SqlParameter("@especialidad", espe);
            SqlParameter paramInc = new SqlParameter("@incremento", incremento);
            this.Database.ExecuteSqlRaw(sql, paramEs,paramInc);
        }

        public List<Doctor> GetDocsPorEsp(string especialidad)
        {
            //String sql = "GETDOCTORESPORESP";
            //SqlParameter paramEs = new SqlParameter("@especialidad", especialidad);
            //var doctores = from datos in this.Doctores
            //                        where datos.Especialidad == especialidad
            //                        select datos;
            //return doctores.ToList() ;
            String sql = "GETDOCTORESPORESP @especialidad";
            SqlParameter paramEs = new SqlParameter("@especialidad", especialidad);
            List<Doctor> doctores = this.Doctores.FromSqlRaw(sql,paramEs).ToList();
            return doctores;
        }


        #region PROCEDURESDOC
        //create procedure cambiarespecialidad(@iddoctor int, @especialidad nvarchar(30))
        //as
        // update DOCTOR set ESPECIALIDAD = @especialidad
        // where DOCTOR_NO = @iddoctor



        //    CREATE PROCEDURE[dbo].[Procedure]
        //@param1 int = 0,
        // @param2 int
        //AS

        //SELECT @param1, @param2
        //RETURN 0

        /*
         create procedure MODIFICARSALARIOESP (@incremento int, @especialidad nvarchar(255))
        as
	        update DOCTOR set SALARIO = SALARIO+@incremento 
	        where ESPECIALIDAD = @especialidad 
        go

        create procedure GETESPECIALIDADES
        as
	        select distinct especialidad from doctor
        go

        create procedure GETDOCTORESPORESP (@especialidad nvarchar (255))
        as
	        select * from DOCTOR where ESPECIALIDAD = @especialidad
        go
         */


        /*
          procedure procempleadoshospital
(@hospitalcod int, @suma int out, @media int out)
as
	select * from DOCTORESPLANTILLA 
	where hospital_cod=@hospitalcod
	select @suma = SUM(salario),
	@media = AVG(salario)
	from DOCTORESPLANTILLA
	where hospital_cod=@hospitalcod
go

USE [HOSPITAL]
GO

        SET ANSI_NULLS ON
        GO

SET QUOTED_IDENTIFIER ON
GO

    ------------------------------------------------
    ALTER VIEW[dbo].[DOCTORESPLANTILLA]
        AS

   select ISNULL(empleado_no,0) as Idempleado
		,apellido,funcion,salario,hospital_cod
        from plantilla
        union

        select doctor_no, apellido, especialidad, salario, hospital_cod

        from doctor
GO



         */

        /*
          ALTER VIEW [dbo].[TOTALEMPLEADOS]
    AS

		(select ISNULL(empleado_no,0) as Idempleado
		,apellido,funcion,salario,HOSPITAL.NOMBRE,
		Plantilla.HOSPITAL_COD as code
		from plantilla
		inner join HOSPITAL
		on HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD)

		union
		
		(select doctor_no,apellido,especialidad,salario,HOSPITAL.Nombre,
		DOCTOR.HOSPITAL_COD
		from doctor
		inner join HOSPITAL
		on HOSPITAL.HOSPITAL_COD = DOCTOR.HOSPITAL_COD)

		union

		(select EMP_NO,apellido,oficio,salario,DEPT.DNOMBRE
		,EMP.DEPT_NO
		from EMP
		inner join DEPT
		on DEPT.DEPT_NO = EMP.DEPT_NO)

        -----------------------------------------------------------------------
        USE [HOSPITAL]
        GO
        SET ANSI_NULLS ON
        GO

        SET QUOTED_IDENTIFIER ON
        GO

        CREATE procedure PROCTOTALEMPLEADOS
        (@code int, @suma int out, @media int out)
        as
	        select* from TOTALEMPLEADOS
           where code = @code
           select @suma = SUM(salario),
	        @media = avg(salario)

            from TOTALEMPLEADOS

            where code = @code
        GO
        ----------------------------------------------------------------
        USE [HOSPITAL]
        GO

        SET ANSI_NULLS ON
        GO

        SET QUOTED_IDENTIFIER ON
        GO


        CREATE procedure[dbo].[PROCTOTALEMPLEADOSDESTINOS]

        as
	        select distinct NOMBRE from TOTALEMPLEADOS


        GO





*/

        #endregion
    }
}
