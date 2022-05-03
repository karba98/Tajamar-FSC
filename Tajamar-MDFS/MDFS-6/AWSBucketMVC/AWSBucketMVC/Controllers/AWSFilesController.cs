using AWSBucketMVC.Helpers;
using AWSBucketMVC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AWSBucketMVC.Controllers
{
    public class AWSFilesController : Controller
    {
        private UploadHelper uploadhelper;
        private ServiceAWSS3 service;
        public AWSFilesController (UploadHelper uploadhelper, 
            ServiceAWSS3 service)
        {
            this.service = service;
            this.uploadhelper = uploadhelper;
        }
        public async Task<IActionResult> ListFiles()
        {
            List<String> files = await this.service.GetS3FilesAsync();
            return View(files);
        }
        public IActionResult UploadFiles()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UploadFiles(IFormFile fichero)
        {
            //String path = await uploadhelper
            //    .UploadFIleAsync(fichero, Folders.Images);
            //using (FileStream stream =
            //    new FileStream(path, FileMode.Open, FileAccess.Read))
            //{
            //    bool respuesta = await service
            //        .UploadFileAsync(fichero.FileName, stream);
            //    if(respuesta == true) 
            //        ViewBag.Mensaje = "Subido correctamente";
            //    else
            //        ViewBag.Mensaje = "No se pudo subir el fichero";
            //}

            using (var stream = fichero.OpenReadStream())
            {

                bool respuesta = await service
                    .UploadFileAsync(fichero.FileName, stream);
                if (respuesta == true)
                    ViewBag.Mensaje = "Subido correctamente";
                else
                    ViewBag.Mensaje = "No se pudo subir el fichero";
            }

            return View();
        }
        public async Task<IActionResult> GetFile(String filename)
        {
            Stream stream = await service.GetFileAsync(filename);
            return new FileStreamResult(stream, "image/jpeg");
            
        }
        public async Task<IActionResult> DeleteFile(String filename)
        {
            await this.service.DeletFileAsync(filename);
            return RedirectToAction("ListFiles");
        }
    }
}
