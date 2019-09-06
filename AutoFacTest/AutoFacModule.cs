using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacTest
{
    public class AutoFacModule:Module
    {
        private bool _isInstancePerRequest;

        public AutoFacModule(bool isInstancePerRequest)
        {
            _isInstancePerRequest = isInstancePerRequest;
        }

        protected override void Load(ContainerBuilder builder)
        {
            if (_isInstancePerRequest)
            {
                builder.RegisterAssemblyTypes(ThisAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            }
        }
    }
}
