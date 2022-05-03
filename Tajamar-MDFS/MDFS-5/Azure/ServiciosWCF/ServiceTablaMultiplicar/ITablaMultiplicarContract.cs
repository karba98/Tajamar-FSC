using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTablaMultiplicar
{
    [ServiceContract]
    public interface ITablaMultiplicarContract
    {
        [OperationContract]
        List<int> GetTablaMultiplicat(int numero);
    }
}
