using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Products.Domain.Dto;
using Products.Domain.Options;

namespace Products.Service.Extensions
{
    public static class DependencyRegistrarExtensions
    {
        /// <summary>
        /// Register dependency injection
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        /// <param name="configuration">IConfiguration</param>
        /// <returns></returns>
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services,
            IConfiguration configuration)
        {
            services
                .Configure<ApplicationOptions>(configuration)
                .Configure<ConnectionStringsOptions>(
                    configuration.GetSection(nameof(ApplicationOptions.ConnectionStrings)))
                .Configure<DbConfig>(configuration.GetSection("ConnectionStrings"));

            return services;
        }
    }
}
