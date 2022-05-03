using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WilsonInformer.Services;

namespace WilsonInformer.ViewComponents
{
    public class EstadisticasEstadoViewComponent : ViewComponent
    {
        public ServicePartes service;
        public EstadisticasEstadoViewComponent (ServicePartes service)
        {
            this.service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Dictionary<string, int> data = await service.GetEstados(HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));

            if (data != null)
            {
                int total = 0;
                foreach (var dato in data)
                {
                    total += dato.Value;
                }
                ViewBag.Total = total;
                ViewBag.Data = data;

            }
            return View();
            //@await Component.InvokeAsync("EstadisticasEstado")
        }
    }
}
