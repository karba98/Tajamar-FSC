using MvcCoreNuevo.Data;
using MvcCoreNuevo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MvcCoreNuevo.Repositories
{
    #region VIEWS
    /*
    Create VIEW VISTADEPTPAGED
    as
    select ISNULL (ROW_NUMBER() over (order by dept_no),0) as POSICION, 
    ISNULL(DEPT.DEPT_NO,0) as DEPT_NO,
    DEPT.DNOMBRE,
    DEPT.LOC
    from dept
    go
     */
    #endregion
    #region PROCEDURES
    /*
    create procedure SPROCEDUREDEPTPAGED
    (@posicion int, @registros int out)
    as
	    select @registros = count(dept_no) from vistadept
	    select DEPT_NO,DNOMBRE,LOC from VISTADEPTPAGED 
	    where POSICION = @posicion
    go



    
    ALTER procedure SPROCEDUREDEPTGRUPOPAGED
    (@posicion int, @registros int out)
    as
	    select @registros = count(dept_no) from VISTADEPTPAGED
	    select DEPT_NO,DNOMBRE,LOC from VISTADEPTPAGED 
	    where POSICION >= @posicion and POSICION<(POSICION+2)
    go



    create procedure PROCEDURETRABAJADORES
    (@posicion int, @registros int out)
    as
	select @registros = count(POSICION) from trabajadorespaged
	select APELLIDO,SALARIO,OFICIO from TRABAJADORESPAGED 
	where POSICION >= @posicion and POSICION<(@posicion+4)
	GO
    --------------------------------------------


    alter procedure PROCEDURETRABAJADORESSALARIO
    (@posicion int, @salario int, @registros int out)
    as
	select @registros = count(POSICION) from trabajadorespaged
	where SALARIO >= @salario

	select APELLIDO,SALARIO,OFICIO 
	from
	(
	select 	ISNULL (ROW_NUMBER() over (order by trabajadores.APELLIDO),0) as POSICION, 
	*
	from TRABAJADORES
	where SALARIO >= @salario) AS TRAB

	where TRAB.POSICION >= @posicion and TRAB.POSICION<(@posicion+4)
	go

     */
    #endregion
    public class RepositoryHospital : IRepositoryHospital
    {
        HospitalContext context;
        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }
        public List<Departamento> GetDepartamentos()
        {
            return context.Departamentos.ToList();
        }

        public Departamento GetDept(int id)
        {
            return context.Departamentos.SingleOrDefault(x => x.Numero == id);
        }

        public Departamento GetRegistroSP(int posicion, ref int registros)
        {
            String sql = "SPROCEDUREDEPTPAGED @POSICION, @REGISTROS OUT";
            SqlParameter param = new SqlParameter("@POSICION", posicion);
            SqlParameter paramOut = new SqlParameter("@REGISTROS",-1);
            paramOut.Direction = System.Data.ParameterDirection.Output;
            Departamento dept = this.context.Departamentos
                .FromSqlRaw<Departamento>(sql, param,paramOut).AsEnumerable().FirstOrDefault();
            registros = Convert.ToInt32(paramOut.Value);
            
            return dept;
        }

        public List<VistaDept> GetGrupoDept(int posicion)
        {
            var consulta = from datos in context.VistaDepartamentos
                           where datos.Posicion >= posicion
                           && datos.Posicion < (posicion + 2)
                           select datos;
            return consulta.ToList();
        }

        public VistaDept GetRegistroDept(int posicion)
        {
            return 
                this.context.VistaDepartamentos
                .Where(x => x.Posicion == posicion)
                .FirstOrDefault();
        }

        public int NumeroRegistrosVistaDept()
        {
            return context.VistaDepartamentos.Count();
        }

        public List<Departamento> GetGrupoDeptsp(int posicion, ref int registros)
        {
            String sql = "SPROCEDUREDEPTGRUPOPAGED @POSICION, @REGISTROS OUT";
            SqlParameter param = new SqlParameter("@POSICION", posicion);
            SqlParameter paramOut = new SqlParameter("@REGISTROS", -1);
            paramOut.Direction = System.Data.ParameterDirection.Output;
            List<Departamento> depts = this.context.Departamentos
                .FromSqlRaw<Departamento>(sql, param, paramOut).ToList();
            registros = Convert.ToInt32(paramOut.Value);

            return depts;
        }
        #region CORRECION VISTAS Y PROCEDURES PAGINACION
        /*
         *CREATE VIEW TRABAJADORES 
        AS
        SELECT ISNULL (EMP_no,0) AS IDEMPLEADO
        ,APELLIDO, OFICIO AS TRABAJO , SALARIO FROM EMP
        UNION
        SELECT DOCTOR_NO, APELLIDO, ESPECIALIDAD, SALARIO
        FROM DOCTOR
        UNION
        SELECT EMPLEADO_NO, APELLIDO, FUNCION, SALARIO 
        FROM PLANTILLA
        go

        CREATE VIEW PAGINABLETRABAJADORES
        AS
        SELECT ROW_NUMBER() OVER (ORDER BY APELLIDO)
        AS POSICION
        ,TRABAJADORES.* FROM TRABAJADORES
        GO

        CREATE PROCEDURE PAGINARTRABAJADORES
        (@POSICION INT, @REGISTROS INT OUT)
        AS
        SELECT @REGISTROS = COUNT (IDEMPLEADO)
        FROM PAGINABLETRABAJADORES
        SELECT * FROM PAGINABLETRABAJADORES
        WHERE POSICION>=@POSICION AND POSICION<(@POSICION+4)
        GO


            ------------------------------------------------
        ALTER PROCEDURE PAGINARTRABAJADORESSALARIO
        (@POSICION INT, @SALARIO INT, @REGISTROS INT OUT)
        AS
        SELECT @REGISTROS = COUNT (IDEMPLEADO)
        FROM TRABAJADORES
        WHERE SALARIO>=@SALARIO
        SELECT *
        FROM
            (SELECT ROW_NUMBER() OVER (ORDER BY APELLIDO)
            AS POSICION, TRABAJADORES.* FROM TRABAJADORES
            WHERE SALARIO >= @SALARIO)
            CONSULTA
        WHERE CONSULTA.POSICION>=@POSICION 
        AND CONSULTA.POSICION<(@POSICION+4)
        GO
         */
        #endregion
        public List<Trabajador> GetTrabajadoresGrupo(int posicion, ref int registros)
        {
            //EJERCICIO EN CLASE

            //String sql = "PROCEDURETRABAJADORES @POSICION, @REGISTROS OUT";
            //SqlParameter param = new SqlParameter("@POSICION", posicion);
            //SqlParameter paramOut = new SqlParameter("@REGISTROS", -1);
            //paramOut.Direction = System.Data.ParameterDirection.Output;
            //List<Trabajador> trabajadores = this.context.Trabajadores
            //    .FromSqlRaw<Trabajador>(sql, param, paramOut).ToList();
            //registros = Convert.ToInt32(paramOut.Value);

            //return trabajadores;

            //CORRECCION EN CASA
            String sql = "PAGINARTRABAJADORES @POSICION, @REGISTROS OUT";
            SqlParameter param = new SqlParameter("@POSICION", posicion);
            SqlParameter paramOut = new SqlParameter("@REGISTROS", -1);
            paramOut.Direction = System.Data.ParameterDirection.Output;
            List<Trabajador> trabajadores = this.context.Trabajadores
                .FromSqlRaw<Trabajador>(sql, param, paramOut).ToList();
            registros = Convert.ToInt32(paramOut.Value);

            return trabajadores;

        }
        public List<Trabajador> GetTrabajadoresGrupoSalario(int posicion, ref int registros,int salario)
        {
            //EJERCCIO
            //String sql = "PROCEDURETRABAJADORESSALARIO @POSICION, @salario,@REGISTROS OUT";
            //SqlParameter param = new SqlParameter("@POSICION", posicion);
            //SqlParameter paramS = new SqlParameter("@salario", salario);
            //SqlParameter paramOut = new SqlParameter("@REGISTROS", -1);
            //paramOut.Direction = System.Data.ParameterDirection.Output;
            //List<Trabajador> trabajadores = this.context.Trabajadores
            //    .FromSqlRaw<Trabajador>(sql, param,paramS, paramOut).ToList();
            //registros = Convert.ToInt32(paramOut.Value);

            //return trabajadores;

            //CORRECCION CAS
            String sql = "PAGINARTRABAJADORESSALARIO @POSICION, @SALARIO,@REGISTROS OUT";
            SqlParameter param = new SqlParameter("@POSICION", posicion);
            SqlParameter paramS = new SqlParameter("@SALARIO", salario);
            SqlParameter paramOut = new SqlParameter("@REGISTROS", -1);
            paramOut.Direction = System.Data.ParameterDirection.Output;
            List<Trabajador> trabajadores = this.context.Trabajadores
                .FromSqlRaw<Trabajador>(sql, param, paramS, paramOut).ToList();
            registros = Convert.ToInt32(paramOut.Value);

            return trabajadores;
        }
    }
}
