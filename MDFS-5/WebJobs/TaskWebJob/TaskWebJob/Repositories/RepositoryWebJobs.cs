using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using TaskWebJob.Data;
using TaskWebJob.Models;

namespace TaskWebJob.Repositories
{
    public class RepositoryWebJobs
    {
        WebJobContext context;
        public RepositoryWebJobs(WebJobContext context)
        {
            this.context = context;
        }
        public List<NoticiaRss> GetRss()
        {
            XNamespace media = "http://search.yahoo.com/mrss/";
            String url = "http://www.chollometro.com/rss/categorias/consolas-y-videojuegos?page=1";
            XDocument docxml = XDocument.Load(url);
            var consulta = from datos in docxml.Descendants("item")
                           select new NoticiaRss
                           {
                               Title = datos.Element("title").Value,
                               Link = datos.Element("link").Value,
                               Description = datos.Element("description").Value,
                               Img = datos.Element(media +"content").Attribute("url").Value
                           };
            return consulta.ToList();
        }
        public void PopulateDataWebJob()
        {
            List<NoticiaRss> noticias = GetRss();
            int id = GetMaxId();
            foreach (NoticiaRss noticia in noticias)
            {
                WebJob wb = new WebJob
                {
                    Descripcion = noticia.Description,
                    Enlace = noticia.Link,
                    Fecha = DateTime.Now,
                    Titulo = noticia.Title,
                    IdTitular = id,
                    Img = noticia.Img

                };
                this.context.WebJobs.Add(wb);
                id++;
            }
            context.SaveChanges();
        }
        private int GetMaxId()
        {
            if (this.context.WebJobs.Count() == 0)
            {
                return 1;
            }
            else
            {
                return this.context.WebJobs.Max(x => x.IdTitular) + 1;
            }
        }
        
    }
}
