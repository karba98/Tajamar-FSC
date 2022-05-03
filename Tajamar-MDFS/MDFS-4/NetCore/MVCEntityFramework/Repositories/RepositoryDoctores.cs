using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCEntityFramework.Data;
using MVCEntityFramework.Models;
using MVCEntityFramework.Repositories;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;

namespace MVCEntityFramework.Repositories
{
    public class RepositoryDoctores
    {
        //PROCEDIMIENTO ALMACERNADO
        HospitalContext context;
        public RepositoryDoctores(HospitalContext context)
        {
            this.context = context;
        }
        //EN EL CASO DE HACER ESTE METODO QUE ESTÄ EN EL CONTEXT,
        //SI LO QUISIERA HACER AQUI:
        //public void ModificarEspecialidad(int doctor, String espe)
        //{
        //    String sql = "cambiarespecialidad @iddoctor, @especialidad";
        //    SqlParameter paramId = new SqlParameter("@iddoctor", doctor);
        //    SqlParameter paramEs = new SqlParameter("@especialidad", espe);
        //    //SOLO CAMBIARIA ESTA LINEA
        //    this.context.Database.ExecuteSqlRaw(sql, paramId, paramEs);
        //}

        public void UpdateEspecialidad(int id, String especialidad)
        {
            context.ModificarEspecialidad(id, especialidad);
        }
        public List<Doctor> GetDoctores()
        {
            String sql = "MostrarDoctores";
            List <Doctor> doctores = this.context.Doctores.FromSqlRaw(sql).ToList();
            return doctores;
        }
        public List<Doctor> GetDoctoresEspecialidad(String especialidad)
        {
            List<Doctor> doctores = context.GetDocsPorEsp(especialidad);
            return doctores;
        }
        public List<String> GetEspecialidades()
        {
            using (DbCommand command = this.context.Database.GetDbConnection().CreateCommand())
            {
                String sql = "GETESPECIALIDADES";
                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection.Open();
                DbDataReader reader = command.ExecuteReader();
                List<String> especialidades = new List<String>();
                while (reader.Read())
                {
                    especialidades.Add(reader["ESPECIALIDAD"].ToString());
                }
                command.Connection.Close();
                return especialidades;
            }

            //var consulta = (from datos in context.Doctores
            //               select datos.Especialidad).Distinct();
            //return (List<string>)consulta.ToList() ; 
        }
        
        public void UpdateSalarioEspecialidad(int salario, String especialidad)
        {
            context.ModificarSalarioEspecialidad(salario, especialidad);
        }
    }
}
