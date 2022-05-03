using MvcCore.Helpers;
using MvcCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MvcCore.Repositories
{
    public class RepositoryDepartamentosXML: IRepositoryDepartamentos
    {
        private PathProvider provider;
        private XDocument docXML;
        private String path;

        public RepositoryDepartamentosXML(PathProvider provider)
        {
            this.provider = provider;
            this.path = provider.MapPath("departamentos.xml", Folders.Documents);
            docXML = XDocument.Load(path);
        }

        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in docXML.Descendants("DEPARTAMENTO")
                           select new Departamento
                           {
                               Numero = Convert.ToInt32(datos.Attribute("NUMERO").Value),
                               localidad = datos.Element("LOCALIDAD").Value.ToString(),
                               Nombre = datos.Element("NOMBRE").Value.ToString()
                           };
            return consulta.ToList();
        }

        public Departamento GetDepartamento(int id)
        {
            var consulta = from datos in docXML.Descendants("DEPARTAMENTO")
                           where datos.Attribute("NUMERO").Value == id.ToString()
                           select new Departamento
                           {
                               Numero = Convert.ToInt32(datos.Attribute("NUMERO").Value),
                               localidad = datos.Element("LOCALIDAD").Value.ToString(),
                               Nombre = datos.Element("NOMBRE").Value.ToString()
                           };
            return consulta.FirstOrDefault();
        }

        public void DeleteDepartamento(int id)
        {
            var consulta = from datos in docXML.Descendants("DEPARTAMENTO")
                           where datos.Attribute("NUMERO").Value == id.ToString()
                           select datos;
            XElement element = consulta.FirstOrDefault();
            element.Remove();
            docXML.Save(this.path);
        }

        public void InsertDepartamento(int numero, String nombre, String localidad)
        {
            XElement element = new XElement("DEPARTAMENTO");
            XAttribute atrnumero = new XAttribute("NUMERO", numero.ToString());
            element.Add(atrnumero);
            XElement enombre = new XElement("NOMBRE", nombre);
            XElement elocalidad = new XElement("LOCALIDAD", localidad);

            element.Add(enombre);
            element.Add(elocalidad);

            docXML.Element("DEPARTAMENTOS").Add(element);
            docXML.Save(path);
        }

        public void UpdateDepartamento(int numero, String nombre, String localidad)
        {
            var consulta = from datos in docXML.Descendants("DEPARTAMENTO")
                           where datos.Attribute("NUMERO").Value == numero.ToString()
                           select datos;
            XElement elemetn = consulta.FirstOrDefault();
            elemetn.Attribute("NUMERO").Value = numero.ToString();
            elemetn.Element("NOMBRE").Value = nombre;
            elemetn.Element("LOCALIDAD").Value = localidad;
            docXML.Save(path);
        }

        public void InsertDepartamento(int numero, string nombre, string localidad, string filename)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartamento(int numero, string nombre, string localidad, string filename)
        {
            throw new NotImplementedException();
        }
    }
}