using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WilsonInformer.Filter;
using WilsonInformer.Helpers;
using WilsonInformer.Models;
using WilsonInformer.Utility;
using WSegInformer.Utility;
using X.PagedList;
using PdfSharp;
using PdfSharp.Pdf;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using TheArtOfDev.HtmlRenderer;
using GrapeCity;
using GrapeCity.Documents.Html;
using WilsonInformer.Services;
using Microsoft.Extensions.Logging;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Security.Claims;

namespace WilsonInformer.Controllers
{
    [AuthorizeUsers]
    public class PartesController : Controller
    {
        //private IRepositoryPartes repos;
        private PathProvider provider;
        public ILogger _logger;
        private ServicePartes service;

        public PartesController(ServicePartes service,PathProvider provider,ILogger<PartesController> _logger)
        {
            this._logger = _logger;
            this.service = service;
            this.provider = provider;
            
        }
        public async Task<IActionResult> QuienesSomos()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            List<Parte> partes = await service.GetPartesDB(HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
            List<Parte> partescerrados = await service.GetPartesCerrados(HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
            List<Parte> partesentregados = await service.GetPartesEntregadosEnGestion(HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
            if(partes == null)
            {
                ViewBag.TotalPartes = 0;
                ViewBag.Cerrados = 0;
                ViewBag.CerradosSF = 0;
                ViewBag.EntregadosEnGestion = 0;

            }
            else
            {
                ViewBag.TotalPartes = partes.Count();
                ViewBag.Cerrados = partescerrados.Count();
                ViewBag.CerradosSF = await service.GetNumPartesCerradosSinF(HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
                ViewBag.EntregadosEnGestion = partesentregados.Count();
            }
            return View();
        }

        public async Task<IActionResult> DeleteAllPartes()
        {
            await service.ClearDB(HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
            return RedirectToAction("UploadPartes",new{ deleted =true});
        }
        public IActionResult UploadPartes(bool? deleted)
        {
            if (deleted!=null)
            {
                ViewBag.Message = "Datos borrados con exito";

                ViewBag.type = "alert alert-success";
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadPartes(List<IFormFile> postedFiles)
        {
            if (postedFiles.Count > 0)
            {
                IFormFile file = postedFiles.First();
                if (file.FileName.EndsWith(".csv"))
                {
                    try
                    {
                        List<Parte> partesCsv = ReadCSV(file);
                        if (partesCsv != null)
                        {
                            int afectados = await service.InsertListaPartes(partesCsv,HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
                            if (afectados > 0)
                            {
                                ViewBag.Message = "Cargado con exito.";

                                ViewBag.type = "alert alert-success";
                                return View();
                            }
                            else
                            {
                                ViewBag.Message = "No se insertaron nuevos partes.";
                                ViewBag.type = "alert alert-danger";
                                return View();
                            }
                        }
                        else
                        {
                            ViewBag.Message = "Error al leer Fichero, " +
                           "los registros del fichero pueden " +
                           "no ser validos.";
                            ViewBag.type = "alert alert-danger";
                            return View();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = "Error al leer Fichero, " +
                            "los registros del fichero pueden " +
                            "no ser validos.";
                        ViewBag.type = "alert alert-danger";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Message = "Error: " + file.FileName + " puede no ser un fichero CSV";
                    ViewBag.type = "alert alert-danger";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Seleccione un fichero";
                ViewBag.type = "alert alert-warning";
                return View();
            }
        }
        public List<Parte> ReadCSV(IFormFile file)
        {
            using (var reader = new StreamReader(file.OpenReadStream()))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                {
                    try
                    {
                        csvReader.Configuration.RegisterClassMap<ParteMap>();
                        //var records = csvReader.GetRecords<Parte>().ToList();
                        //int afectados = InsertListaPartes(records);
                        //return afectados;
                        List<Parte> records = csvReader.GetRecords<Parte>().ToList();
                        return records;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }
        }
        public async Task<IActionResult> GetPartes(int? page, String? nalbaran, String? nparte, DateTime? dateFrom, DateTime? dateTo)
        {
            List<Parte> partes = new List<Parte>();
            if (nalbaran != null || nparte != null)
            {
                ViewBag.searchValPAR = nparte;
                ViewBag.searchValALB = nalbaran;

                partes = await service.GetPartesDBAlbaranParte(nalbaran, nparte,HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
            }
            else
            {
                partes = await  service.GetPartesDB(HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
            }


            if (dateFrom != null && dateTo != null)
            {
                partes = await service.GetPartesFecha(dateTo.Value, dateFrom.Value,partes,HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));

                ViewBag.FilteredFecha = true;
                ViewBag.DateFrom = dateFrom;
                ViewBag.DateTo = dateTo;

                Dictionary<String, int> partesporfecha = await service.SetPartesFechaGraphicData(partes,HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));

                String[] cadenasinfo = partesporfecha.Keys.ToArray();
                String fechas = "[\""+string.Join("\",\"", cadenasinfo)+"\"]";
                
                int[] cadenasinfoPartes = partesporfecha.Values.ToArray();
                String npartes = "["+string.Join(",", cadenasinfoPartes)+"]";

                ViewBag.Npartes = npartes;
                ViewBag.Fechas = fechas;
             
            }
            if (partes != null)
            {
                ViewBag.Resultados = partes.Count();
                return View(partes.ToPagedList(page ?? 1, 50));
            }
            else
            {
                return View();
            }
           
        }

        [HttpPost]
        public IActionResult GetPartes(String nalbaran, String nparte, DateTime dateFrom, DateTime dateTo)
        {
            if (dateFrom == default(DateTime) || dateTo == default(DateTime))
            {
                return RedirectToAction("GetPartes", new { nparte = nparte, nalbaran = nalbaran });
            }
            else
            {
                return RedirectToAction("GetPartes", new { nparte = nparte, nalbaran = nalbaran, dateTo = dateTo, dateFrom = dateFrom });
            }
        }

        public async Task<IActionResult> PartePerdida(String nparte, bool? error)
        {
            var map = MapSelectResParte.GetMapResultados();
            ViewBag.resultados = map;
            Parte parte = await service.GetParte(nparte,HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
            if (error == true)
            {
                ViewBag.type = "alert alert-danger";
                ViewBag.Error = "Seleccione un resultado final";
            }
            if (parte != null)
            {
                ViewBag.nparte = parte.N_parte;
                
                return View(parte);
            }
            else
            {
                ViewBag.type = "alert alert-danger";
                ViewBag.nparte = "No se encontró el parte seleccionado";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PartePerdida(String resf, String seguimiento, String parte)
        {
            Parte p = await service.GetParte(parte,HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
            if (resf != null)
            {
                try
                {
                    String filename = "Parte Perdia " + parte + ".pdf";

                    //GRAPECITY
                    //MemoryStream stream = RenderPDF(filename, p, seguimiento, resf);
                    //return File(stream, "application/pdf", filename);


                    byte[] filecontents;
                    MemoryStream stream = RenderPDF(filename, p, seguimiento, resf);
                    filecontents = stream.ToArray();
                    stream.Position = 0;
                    stream.Flush();

                    //return Content(@"<!DOCTYPE html>" +
                    //$"<html><head></head><body><a style=\"display:none\" id=\"linker\" href=\"data:application/octet-stream;charset=utf-8;base64," +
                    //$"{Convert.ToBase64String(filecontents)}\" download=\"" + filename + ".pdf\">Download this file</a>" +
                    //"</body>" +
                    //"<script>document.addEventListener('DOMContentLoaded', function(){document.getElementById('linker').click(); window.location='/'}, false);</script>" +
                    //"</html>", "text/html");


                    return new FileContentResult(filecontents, "application/pdf") 
                    {
                        FileDownloadName = filename
                    };

                    ////PDFSHARP
                    //byte[] bytearray = null;
                    //MemoryStream stream;
                    //using (stream = new MemoryStream())
                    //{

                    //    String html = TemplateGenerator.GetHTMLParte(p, seguimiento, resf);
                    //    PdfDocument pdf = PdfGenerator.GeneratePdf(html, PageSize.B5);
                    //    ViewBag.type = "alert alert-success";
                    //    ViewBag.nparte = "Parte generado con exito";
                    //    pdf.Save(stream, false);
                    //    bytearray = stream.ToArray();
                    //    return File(new MemoryStream(bytearray), "application/pdf", filename);

                    //};
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    _logger.LogError("An example of an Error level message");
                    return RedirectToAction("PartePerdida", "Partes", new { nparte = parte, error = true });
                }

            }
            else
            {
                return RedirectToAction("PartePerdida", "Partes", new { nparte = parte, error = true });
            }
        }
      
        public MemoryStream RenderPDF(string filename, Parte p, String seguimiento, String resf)
        {
            MemoryStream stream = new MemoryStream();
            //GRAPECITY
            using (var re = new GcHtmlRenderer(TemplateGenerator.GetHTMLParte(p, seguimiento, resf)))
            {
                PdfSettings setting = new PdfSettings();
                setting.FullPage = true;
                re.RenderToPdf(stream,setting);
        
                stream.Flush();
                stream.Position = 0;
            }
            return stream;


        }

        public async Task<IActionResult> EntregadosEnGestion(int? page)
        {
            List<Parte> partes = await service.GetPartesEntregadosEnGestion(HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
            if (partes == null)
            {
                return View();
            }
            else
            {
                ViewBag.Resultados = partes.Count();
                return View(partes.ToPagedList(page ?? 1, 50));
            }
        }

        public async Task<IActionResult> Pendientes15(int? page)
        {
            String ago = DateTime.Now.AddDays(-15)
                    .ToString("dd/MM/yy", CultureInfo.InvariantCulture);
            ViewBag.ago = ago;
            List<Parte> partes = await service.GetPartesPendientes15(HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));

            if (partes == null)
            {
                return View();
            }
            else
            {
                ViewBag.Resultados = partes.Count();
                return View(partes.ToPagedList(page ?? 1, 50));
            }
        }

        public IActionResult Estadisticas()
        {
            return View();
            
        }
    }
}