using ServiceClientesDataContract.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServiceClientesDataContract.Repositories
{
    public class RepositoryClientes
    {
        XDocument doc;
        public RepositoryClientes()
        {
            //EL XML EN PROPIEDADES TIENE QUE ESTAR OMO EMBEBED
            //NAMESPACE.FICHERO o NAEMSPACE.CARPETA.FICHERO
            String resource = "ServiceClientesDataContract.ClientesXML.xml";
            Stream stream = this.GetType().Assembly.GetManifestResourceStream(resource);
            this.doc = XDocument.Load(stream);
        }
        public List<Cliente> GetClientes()
        {
            var consulta = from datos in doc.Descendants("CLIENTE")
                           select new Cliente
                           {
                               IdCliente = int.Parse(datos.Attribute("IDCLIENTE").Value),
                               Email = datos.Element("EMAIL").Value,
                               Nombre = datos.Element("NOMBRE").Value,
                               ImagenCliente = datos.Element("IMAGENCLIENTE").Value
                           };
            return consulta.ToList();
        }
        public Cliente BuscarCliente(int id)
        {
            return this.GetClientes().SingleOrDefault(x => x.IdCliente == id);
        }
    }
}
