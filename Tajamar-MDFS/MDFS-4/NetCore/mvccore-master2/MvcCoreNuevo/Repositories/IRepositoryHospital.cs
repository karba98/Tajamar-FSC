using MvcCoreNuevo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreNuevo.Repositories
{
    public interface IRepositoryHospital
    {
        public List<Departamento> GetDepartamentos();
        public Departamento GetDept(int id);
        public VistaDept GetRegistroDept(int posicion);
        public int NumeroRegistrosVistaDept();
        public List<VistaDept> GetGrupoDept(int posicion);
        public List<Departamento> GetGrupoDeptsp(int posicion, ref int registros);
        public Departamento GetRegistroSP(int posicion, ref int registros);
        public List<Trabajador> GetTrabajadoresGrupo(int posicion, ref int registros);
        public List<Trabajador> GetTrabajadoresGrupoSalario(int posicion, ref int registros,int salario);

    }
}
