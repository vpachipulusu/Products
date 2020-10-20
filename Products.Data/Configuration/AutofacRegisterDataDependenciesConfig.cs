using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Products.Data.Configuration
{
    public class AutofacRegisterDataDependenciesConfig
    {
        public static ContainerBuilder Register(ContainerBuilder builder)
        {
            //Repositories
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            return builder;
        }
    }
}
