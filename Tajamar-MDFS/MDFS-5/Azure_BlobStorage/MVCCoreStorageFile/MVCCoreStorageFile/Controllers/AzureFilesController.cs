using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreStorageFile.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreStorageFile.Controllers
{
    public class AzureFilesController : Controller
    {
        ServiceStorageFiles service;
        public AzureFilesController(ServiceStorageFiles service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            return View(await service.GetFilesAsync());
        }
        public IActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            String filename = file.FileName;
            using (var stream = file.OpenReadStream())
            {
                await this.service.UploadFile(filename, stream);
            }
            ViewBag.Mensaje = "Subido";
            return View();
        }
        public async Task<IActionResult> DeleteFile(String filename)
        {
            await service.DeleteFile(filename);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detalles(String filename)
        {
            ViewBag.Content = await service.GetFileContentAsync(filename);
            return View();
        }
    }
}
