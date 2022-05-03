using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CochesNuget.Respository
{
    internal class RepositoryCoches
    {
        private XDocument doc;
        public RepositoryCoches()
        {
            String resource = "CochesNuget.coches.xml";
            Stream stream = this.GetType().Assembly.GetManifestResourceStream(resource);
            this.doc = XDocument.Load(stream);
        }
        internal List<Coche> GetCoches()
        {
            var consulta = from datos in doc.Descendants("coche")
                           select new Coche
                           {
                               IdCoche = int.Parse(datos.Element("idcoche").Value),
                               Marca = datos.Element("marca").Value,
                               Modelo = datos.Element("modelo").Value,
                               Imagen = datos.Element("imagen").Value
                           };
            return consulta.ToList();
        }
        public Coche BuscarCoche(int id)
        {
            return GetCoches().SingleOrDefault(x => x.IdCoche == id);
        }
    }
}
