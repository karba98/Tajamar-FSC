using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WilsonInformer.Services;

namespace WilsonInformer.ViewComponents
{
    public class EstadisticasAbonadoViewComponent : ViewComponent
    {

        private ServicePartes service;

        public EstadisticasAbonadoViewComponent (ServicePartes service)
        {
            this.service = service;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
        //    Dictionary<string, int> dataFO = repos.GetFramquiciasOrigen();
        //    Dictionary<string, int> dataFD = repos.GetFramquiciasDestino();

            Dictionary<string, int> dataAbonado = await service.GetAbonados(HttpContext.User.FindFirstValue("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
            if (dataAbonado != null)
            {
                List<String> cadenasinfo = new List<string>();
                foreach (KeyValuePair<string, int> elem in dataAbonado)
                {
                    String s = "[\"" + elem.Key.Replace("\'", " ") + "\"," + elem.Value + "]";
                    cadenasinfo.Add(s);
                }
                String[] cadenas = cadenasinfo.ToArray();
                string abonadosstring = string.Join(",", cadenas);
                ViewBag.Propis = abonadosstring;
                ViewBag.Max = dataAbonado.FirstOrDefault().Value;
                ViewBag.Count = dataAbonado.Count;
            }

            return View();
        }
    }
}
