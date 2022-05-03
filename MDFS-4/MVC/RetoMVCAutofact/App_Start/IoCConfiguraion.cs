using Autofac;
using Autofac.Integration.Mvc;
using RetoMVCAutofac.Data;
using RetoMVCAutofac.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace RetoMVCAutofac.App_Start
{
    public class IoCConfiguration
    {
        public static void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.Register(x => new EmpleadosContext())
            .InstancePerRequest();
            builder.RegisterType<RepositoryEmpleados>()
            .InstancePerRequest();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            IContainer container = builder.Build();
            DependencyResolver.SetResolver
            (new AutofacDependencyResolver(container));
        }
    }

}