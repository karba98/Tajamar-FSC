using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCacheRedis
{
    public class Producto
    {
        public String Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Precio { get; set; }
        public String Imagen { get; set; }
    }
}
