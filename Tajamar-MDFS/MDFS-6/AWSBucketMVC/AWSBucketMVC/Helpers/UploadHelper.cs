using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AWSBucketMVC.Helpers
{
    public class UploadHelper
    {
        private PathProvider provider;
        public UploadHelper(PathProvider provider)
        {
            this.provider = provider;
        }
        public async Task<String> UploadFIleAsync(IFormFile file, Folders folder)
        {
            String filename = file.FileName;
            String path = this.provider.MapPath(filename, folder);
            using (var stream = new FileStream(path,FileMode.Create))
            {
                await file.CopyToAsync(stream);
            };
            return path;
        }
    }
}
