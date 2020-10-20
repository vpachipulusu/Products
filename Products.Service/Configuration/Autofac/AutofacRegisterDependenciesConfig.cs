using Autofac;
using Products.Data.Configuration;
using System.Reflection;

namespace Products.Service.Configuration.Autofac
{
    public class AutofacRegisterDependenciesConfig
    {
        public static ContainerBuilder Register(ContainerBuilder builder)
        {
            //Repositories
            AutofacRegisterDataDependenciesConfig.Register(builder);

            //Services
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            return builder;
        }
    }
}
