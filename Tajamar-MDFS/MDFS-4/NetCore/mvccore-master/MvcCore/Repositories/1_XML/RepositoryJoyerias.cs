using MvcCore.Helpers;
using MvcCore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MvcCore.Repositories
{
    public class RepositoryJoyerias
    {
        private PathProvider provider;
        private XDocument docXML;

        public RepositoryJoyerias(PathProvider provider)
        {
            this.provider = provider;
            string path = provider.MapPath("joyerias.xml", Folders.Documents);
            docXML = XDocument.Load(path);
        }

        public List<Joyeria> GetJoyerias()
        {
            List<Joyeria> joyerias = new List<Joyeria>();

            //CONSULTA DINAMICA
            var consulta = from datos in docXML.Descendants("joyeria")
                           select new Joyeria
                           {
                               Nombre = datos.Element("nombrejoyeria").Value,
                               Cif = datos.Attribute("cif").Value,
                               Direccion = datos.Element("direccion").Value,
                               Telefono = datos.Element("telf").Value
                           };
            joyerias = consulta.ToList();
            return joyerias;
            /*
            CONSULTA MANUAL

            var consulta = from datos in docXML.Descendants("joyeria")
                           select datos;
            foreach (var dato in consulta)
            {
                Joyeria j = new Joyeria();
                j.Nombre = dato.Element("nombrejoyeria").Value;
                j.Direccion = dato.Element("direccion").Value;
                j.Telefono = dato.Element("telf").Value;
                j.Cif = dato.Attribute("cif").Value;
                joyerias.Add(j);
            }
            */
        }
    }
}