using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaAzureMVC.Filters
{
    public class AuthorizeUsersAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;
            if(user.Identity.IsAuthenticated == false)
            {
                String action = context.RouteData.Values["action"].ToString();
                String controller = context.RouteData.Values["controller"].ToString();
                //Recuperar dependencia de startup
                ITempDataProvider provider = 
                    (ITempDataProvider)
                    context.HttpContext.RequestServices
                    .GetService(typeof(ITempDataProvider));
                var TempData = provider.LoadTempData(context.HttpContext);
                TempData["action"] = action;
                TempData["controller"] = controller;
                provider.SaveTempData(context.HttpContext, TempData);

                context.Result = RedirectToRoute("Identity", "Login");
            }
            
        }
        private RedirectToRouteResult RedirectToRoute(String controller, String action)
        {
            RouteValueDictionary ruta = new RouteValueDictionary(new { 
                controller = controller,
                action = action
            });
            RedirectToRouteResult redirect = new RedirectToRouteResult(ruta);
            return redirect;
        }
    }
}
