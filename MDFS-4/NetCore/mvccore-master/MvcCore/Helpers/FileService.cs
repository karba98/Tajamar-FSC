using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Helpers
{
    public class FileService
    {
        PathProvider provider;
        public FileService(PathProvider provider)
        {
            this.provider = provider;
        }
        public async Task<String> UploadFileAsync(IFormFile fichero,Folders folder)
        {
            String filename = fichero.FileName;
            String path = provider.MapPath(filename, folder);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await fichero.CopyToAsync(stream);
            }
            return path;
        }


    }
}
