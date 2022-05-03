using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;

namespace MvcCore.Helpers
{
    public enum Folders
    {
        Images = 0, Documents = 1, Temp =3
    }

    public class PathProvider
    {
        private IWebHostEnvironment environment;

        public PathProvider(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public String MapPath(String filename, Folders folder)
        {
            String carpeta = "";
            if (folder == Folders.Documents)
            {
                carpeta = "documents";
            }
            else if (folder == Folders.Images)
            {
                carpeta = "images";
            }
            else if(folder == Folders.Temp)
            {
                carpeta = "temp";
            }
            String ruta = Path.Combine(environment.WebRootPath, carpeta, filename);
            return ruta;
        }
    }
}