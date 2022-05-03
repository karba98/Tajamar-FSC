using MvcCore.Helpers;
using MvcCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MvcCore.Repositories
{
    public class RepositoryAlumnos
    {
        /*
            <alumno>
            <idalumno>1</idalumno>
            <nombre>Nacho</nombre>
            <apellidos>Shum Llanos</apellidos>
            <nota>8</nota>
            </alumno>
        */
        private PathProvider provider;
        private XDocument docXML;
        private String path;

        public RepositoryAlumnos(PathProvider provider)
        {
            this.provider = provider;
            this.path = provider.MapPath("alumnos.xml", Folders.Documents);
            docXML = XDocument.Load(path);
        }

        public List<Alumno> GetAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            var consulta = from datos in docXML.Descendants("alumno")
                           select new Alumno
                           {
                               IdAlumno = int.Parse(datos.Element("idalumno").Value),
                               Nombre = datos.Element("nombre").Value,
                               Apellidos = datos.Element("apellidos").Value,
                               Nota = int.Parse(datos.Element("nota").Value),
                           };
            alumnos = consulta.ToList();
            return alumnos;
        }

        public void DeleteAlumno(int IdAlumno)
        {
            var consulta = from datos in docXML.Descendants("alumno")
                           where datos.Element("idalumno").Value == IdAlumno.ToString()
                           select datos;
            XElement elementalumno = consulta.FirstOrDefault();
            elementalumno.Remove();
            docXML.Save(this.path);
        }

        public Alumno GetAlumno(int IdAlumno)
        {
            var consulta = from datos in docXML.Descendants("alumno")
                           where datos.Element("idalumno").Value == IdAlumno.ToString()
                           select new Alumno
                           {
                               IdAlumno = int.Parse(datos.Element("idalumno").Value),
                               Nombre = datos.Element("nombre").Value,
                               Apellidos = datos.Element("apellidos").Value,
                               Nota = int.Parse(datos.Element("nota").Value),
                           };
            return consulta.FirstOrDefault();
        }

        public void InsertAlumno(int Id, String Nombre, String Apellidos, int Nota)
        {
            XElement alumno = new XElement("alumno");
            XElement idalumno = new XElement("idalumno", Id);
            XElement nombre = new XElement("nombre", Nombre);
            XElement apellido = new XElement("apellidos", Apellidos);
            XElement nota = new XElement("nota", Nota);

            alumno.Add(idalumno);
            alumno.Add(nombre);
            alumno.Add(apellido);
            alumno.Add(nota);

            docXML.Element("alumnos").Add(alumno);
            docXML.Save(this.path);
        }

        public void UpdateAlumno(int Id, String Nombre, String Apellidos, int Nota)
        {
            var consulta = from datos in docXML.Descendants("alumno")
                           where datos.Element("idalumno").Value == Id.ToString()
                           select datos;
            XElement element = consulta.FirstOrDefault();
            element.Element("nombre").Value = Nombre;
            element.Element("apellidos").Value = Apellidos;
            element.Element("nota").Value = Nota.ToString();
            docXML.Save(this.path);
        }
    }
}