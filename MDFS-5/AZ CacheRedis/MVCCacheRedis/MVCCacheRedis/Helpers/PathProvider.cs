using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCacheRedis.Helpers
{
    public enum Folders
    {
        Upload = 0, Images = 1, Documents = 2
    }

    public class PathProvider
    {
        IWebHostEnvironment environment;

        public PathProvider(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public string MapPath(string filename, Folders folder)
        {
            String carpeta = "";
            if (folder == Folders.Upload)
            {
                carpeta = "uploads";
            }
            else if (folder == Folders.Upload)
            {
                carpeta = "images";
            }
            else if (folder == Folders.Documents)
            {
                carpeta = "documents";
            }
            String path = Path.Combine(this.environment.WebRootPath
                , carpeta, filename);
            return path;
        }
    }
}
