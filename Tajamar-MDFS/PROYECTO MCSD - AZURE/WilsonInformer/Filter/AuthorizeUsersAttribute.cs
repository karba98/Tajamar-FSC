using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilsonInformer.Filter
{
    public class AuthorizeUsersAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var usuario = context.HttpContext.User;
            if (usuario.Identity.IsAuthenticated == false)
            {
                //RECUPERAMOS EL ULTIMO SITIO DONDE HA PULSADO EL USUARIO
                ITempDataProvider provider = context.HttpContext.RequestServices.GetService(typeof(ITempDataProvider)) as ITempDataProvider;
                var TempData = provider.LoadTempData(context.HttpContext);

                String action = context.RouteData.Values["action"].ToString();
                String controller = context.RouteData.Values["controller"].ToString();

                TempData["action"] = action;
                TempData["controller"] = controller;

                provider.SaveTempData(context.HttpContext, TempData);

                context.Result = GetRoute("Credenciales", "Usuarios");
            }
            else
            {
                String action = context.RouteData.Values["action"].ToString();
                String controller = context.RouteData.Values["controller"].ToString();

                if (usuario.IsInRole("V"))
                {
                    switch (action)
                    {
                        case "GetPartes": context.Result = GetRoute("AccesoDenegado", "Usuarios");
                            break;
                        case "UploadPartes": context.Result = GetRoute("AccesoDenegado", "Usuarios");
                            break;
                        case "DeleteAllPartes": context.Result = GetRoute("AccesoDenegado", "Usuarios");
                            break;
                        case "PartesPerdida": context.Result = GetRoute("AccesoDenegado", "Usuarios");
                            break;
                        case "EntregadosEnGestion": context.Result = GetRoute("AccesoDenegado", "Usuarios");
                            break;
                        case "Pendientes15": context.Result = GetRoute("AccesoDenegado", "Usuarios");
                            break;
                        case "Registrar": context.Result = GetRoute("AccesoDenegado", "Usuarios");
                            break;
                    }
                }
            }

        }
        public RedirectToRouteResult GetRoute(String action, String controller)
        {
            RouteValueDictionary ruta = new RouteValueDictionary(new
            {
                action = action,
                controller = controller
            });
            RedirectToRouteResult result = new RedirectToRouteResult(ruta);
            return result;
        }
    }
}
