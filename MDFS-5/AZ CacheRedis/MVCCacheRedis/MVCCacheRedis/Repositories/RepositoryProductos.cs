using MVCCacheRedis.Helpers;
using MVCCacheRedis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVCCacheRedis.Repositories
{

    public class RepositoryProductos
    {
        PathProvider provider;
        XDocument doc;
        public RepositoryProductos(PathProvider provider)
        {
            this.provider = provider;
            String path = provider.MapPath("productos.xml", Folders.Documents);
            doc = XDocument.Load(path);
        }
        public List<Producto> GetProductos()
        {
            var consulta = from datos in doc.Descendants("producto")
                           select new Producto
                           {
                               Id = datos.Element("idproducto").Value,
                               Descripcion = datos.Element("descripcion").Value,
                               Imagen = datos.Element("imagen").Value,
                               Nombre = datos.Element("nombre").Value,
                               Precio = datos.Element("precio").Value
                           };
            return consulta.ToList();
        }
        public Producto BuscarProducto(String id)
        {
            return GetProductos().SingleOrDefault(x => x.Id == id);
        }

    }
}
