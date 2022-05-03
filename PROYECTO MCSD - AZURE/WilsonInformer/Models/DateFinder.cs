using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilsonInformer.Models
{
    public class DateFinder
    {
        public DateTime dateTo { get; set; }
        public DateTime dateFrom { get; set; }
        public List<Parte> listafilter { get; set; }
    }
}
