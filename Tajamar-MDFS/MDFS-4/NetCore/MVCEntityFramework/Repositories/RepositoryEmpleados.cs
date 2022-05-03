using MVCEntityFramework.Data;
using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Repositories
{
    public class RepositoryEmpleados
    {
        EmpleadosContext context;
        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }
        public List<Empleado> GetEmpleados()
        {
            var consulta = from datos in context.Empleados
                           select datos;
            return consulta.ToList();
        }
        public List<Empleado> GetEmpleadosOficio(String oficio)
        {
            var consulta = from datos in context.Empleados
                           where datos.Oficio==oficio
                           select datos;
            return consulta.ToList();
        }
        public List<String> GetOficios()
        {
            var consulta = (from datos in context.Empleados
                            select datos.Oficio).Distinct();
            return consulta.ToList();
        }
        public void IncrementSalario(String oficio, int incremento)
        {
            var consulta = from datos in context.Empleados
                           where datos.Oficio == oficio
                           select datos;
            foreach(Empleado empleado in consulta)
            {
                empleado.Salario = empleado.Salario + incremento;
            }
            context.SaveChanges();
        }
        public ResumenDepartamento GettEmpleadosDepartamento(int dept)
        {
            List<Empleado> empleados = GetEmpleados();
            List<Empleado> filtro = empleados.Where(x => x.Departamento == dept).ToList();
            if (filtro.Count == 0)
            {
                return null;
            }
            ResumenDepartamento rdept = new ResumenDepartamento();
            rdept.Empleados = filtro;
            rdept.NumEmpleados = filtro.Count();
            rdept.Maximo = filtro.Max(x => x.Salario);
            rdept.Minimo = filtro.Min(x => x.Salario);

            return rdept;
        }


    }
}
