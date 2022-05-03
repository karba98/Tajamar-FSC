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
    public class AzureBlobController : Controller
    {
        ServiceStorageBlob service;
        public AzureBlobController(ServiceStorageBlob service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            return View(await service.GetContainers());
        }

        public async Task<IActionResult> CreateContainer(String containerName)
        {
            await service.CreateContainseAsync(containerName);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Container(String containerName)
        {
            ViewBag.Container = containerName;
            return View(await service.GetFiles(containerName));
        }
        [HttpPost]
        public async Task<IActionResult> Container(IFormFile file,String container)
        {
            try
            {
                using (Stream stream = file.OpenReadStream())
                {
                    await service.Upload(file.FileName, stream, container);
                }
                return RedirectToAction("Container", new { containerName = container });
            }catch(Exception ex)
            {
                ViewBag.Mensaje = "Ya existe el fichero";
                ViewBag.Container = container;
                return View(await service.GetFiles(container));
            }
        }
        public async Task<IActionResult> Delete(String fileName,String containerName)
        {
            await service.Delete(fileName, containerName);
            return RedirectToAction("Container", new { containerName = containerName });
        }
        public async Task<IActionResult> DeleteContainer(String containerName)
        {
            await service.DeleteCOntainer(containerName);
            return RedirectToAction("Index");
            
        }
    }
}
