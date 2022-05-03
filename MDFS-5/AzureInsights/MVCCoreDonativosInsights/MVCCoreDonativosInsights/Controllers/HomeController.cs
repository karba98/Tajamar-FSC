using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreDonativosInsights.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String nombre, int cantidad)
        {
            Trace.TraceInformation("nombre: " + nombre + " - cantidad: " + cantidad + "€");
            //TraceTelemetry trace = new TraceTelemetry("nombre: " + nombre + " - cantidad: " + cantidad + "€",
            //    SeverityLevel.Information);
            MetricTelemetry metrica = new MetricTelemetry();

            metrica.Name = "donativos";
            metrica.Sum = cantidad;
            TelemetryClient client = new TelemetryClient(
                new Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration("1a01f0c1-eee2-45ff-9a13-635e8b4b6de7"));
            client.TrackEvent("Eventos donativos");
            client.TrackMetric(metrica);
            return View();
        }
    }
}
