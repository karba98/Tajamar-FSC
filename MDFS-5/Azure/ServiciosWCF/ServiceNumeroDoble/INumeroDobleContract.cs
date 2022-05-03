using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNumeroDoble
{
    [ServiceContract]
    public interface INumeroDobleContract
    {
        [OperationContract]
        int GetNumeroDoble(int numero);
        [OperationContract]
        String GetSaludo(String nombre);
        String Invisible();
    }
}
