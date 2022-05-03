using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MVCEntityFramework.Data;
using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Repositories
{
    public class RepositoryEmpleadosHospital
    {
        HospitalContext context;
        public RepositoryEmpleadosHospital (HospitalContext context)
        {
            this.context = context;
        }
        public List<EmpleadoHospital> GetEmpleadosHospital()
        {
            var consulta = from datos in this.context.EmpleadosHospital
                           select datos;
            return consulta.ToList();
        }
        public ProcedimientoEmpleadoHospital GetEmpleadosHospital(int hcod)
        {
            try
            {
                String sql = "procempleadoshospital @hospitalcod, @suma out, @media out";
                SqlParameter param = new SqlParameter("@hospitalcod", hcod);
                SqlParameter paramOutSuma = new SqlParameter("@suma", -1);
                SqlParameter paramOutMedia = new SqlParameter("@media", -1);
                paramOutMedia.Direction = System.Data.ParameterDirection.Output;
                paramOutSuma.Direction = System.Data.ParameterDirection.Output;
                List<EmpleadoHospital> empleados = this.context.EmpleadosHospital
                    .FromSqlRaw(sql, param, paramOutMedia, paramOutSuma).ToList();
                ProcedimientoEmpleadoHospital salida = new ProcedimientoEmpleadoHospital();
                salida.Empleados = empleados;
                salida.SumaSalarial = Convert.ToInt32(paramOutSuma.Value);
                salida.MediaSalarial = Convert.ToInt32(paramOutMedia.Value);
                return salida;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public List<EmpleadoGenerico> GetEmpleadosHospitalGenerico()
        {
            var consulta = from datos in this.context.EmpleadosGenerico
                           select datos;
            return consulta.ToList();
        }
        public ProcedimientoEmpleadoGenerico GetEmpleadosHospitalGenerico(int hcod)
        {
            try
            {
                String sql = "PROCTOTALEMPLEADOS @hospitalcod, @suma out, @media out";
                SqlParameter param = new SqlParameter("@hospitalcod", hcod);
                SqlParameter paramOutSuma = new SqlParameter("@suma", -1);
                SqlParameter paramOutMedia = new SqlParameter("@media", -1);
                paramOutMedia.Direction = System.Data.ParameterDirection.Output;
                paramOutSuma.Direction = System.Data.ParameterDirection.Output;
                List<EmpleadoGenerico> empleados = this.context.EmpleadosGenerico
                    .FromSqlRaw(sql, param, paramOutMedia, paramOutSuma).ToList();
                ProcedimientoEmpleadoGenerico salida = new ProcedimientoEmpleadoGenerico();
                salida.Empleados = empleados;
                salida.SumaSalarial = Convert.ToInt32(paramOutSuma.Value);
                salida.MediaSalarial = Convert.ToInt32(paramOutMedia.Value);
                return salida;
            }
            catch (Exception ex)
            {
                String e = ex.Message;
                return null;
            }
        }
        public List<Destino> GetDestinosGenerico()
        {
            try
            {
                using (DbCommand command = this.context.Database.GetDbConnection().CreateCommand())
                {
                    String sql = "PROCTOTALEMPLEADOSDESTINOS";
                    command.CommandText = sql;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Connection.Open();
                    DbDataReader reader = command.ExecuteReader();
                    List<Destino> destinos = new List<Destino>();
                    while (reader.Read())
                    {
                        Destino d = new Destino();
                        d.Nombre = reader["NOMBRE"].ToString();
                        d.Value = Convert.ToInt32(reader["Code"]);
                        destinos.Add(d);
                    }
                    command.Connection.Close();
                    return destinos;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
    
}

