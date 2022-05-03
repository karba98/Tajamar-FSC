using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTablaMultiplicar
{
    public class TablaMultiplicarClass : ITablaMultiplicarContract
    {
        public List<int> GetTablaMultiplicat(int numero)
        {
            List<int> resultado = new List<int>();
            for(int i = 1; i <= 10; i++)
            {
                resultado.Add(numero*i);
            }
            return resultado;
        }
    }
}
