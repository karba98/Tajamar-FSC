using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApiDepts.Filters
{
    public class EmpleadosAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {

            var user = context.HttpContext.User;
            if(user.Identity.IsAuthenticated == false || context.HttpContext.Session.GetString("TOKEN")==null )
            {
                RouteValueDictionary rutalogin = new RouteValueDictionary(new
                {
                    controller ="Identity", action="Login"
                });
                context.Result = new RedirectToRouteResult(rutalogin);
            }
        }
    }
}
