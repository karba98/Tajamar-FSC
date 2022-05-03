using System;
using System.Collections.Generic;
using System.Text;

namespace PaginasBinding.Models
{
    public class ListaNumeros
    {
        public List<NumerosViewModel> Numeros { 
            get
            {
                Random r = new Random();
                List<NumerosViewModel> lista = new List<NumerosViewModel>();
                for(int i = 0; i < 50; i++)
                {
                    NumerosViewModel model = new NumerosViewModel();
                    int val = r.Next(-25, 25);
                    model.Valor = val;
                    lista.Add(model);
                }
                return lista;
            }
        }
    }
}
