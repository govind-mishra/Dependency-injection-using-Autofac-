using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Dependable.Extensions.Dependencies.Autofac;

namespace AutoFacTest
{
    public class CreateBuilderBaseClass
    {
        public static IContainer createBuilderforDependecy()
        {
            var isInstancePerRequest = true;
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutoFacModule(isInstancePerRequest));
            builder.RegisterFilterProvider();
            var container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return container;
        }
    }
}
