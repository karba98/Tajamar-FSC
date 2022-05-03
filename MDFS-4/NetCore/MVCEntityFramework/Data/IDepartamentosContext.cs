using MVCEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Data
{
    public interface IDepartamentosContext
    {
        List<Departamento> GetDepartamentos();
    }
}
