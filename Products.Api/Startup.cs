using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Products.Api.Filters;
using Products.Data.EF.Migrations.Context;
using Products.Service.Configuration.Autofac;
using Products.Service.Extensions;

namespace Products.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDependencyInjection(Configuration);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Products Api", Version = "v1" });
                c.OperationFilter<CustomHeaderSwaggerAttribute>();
            });
            services.AddMemoryCache();
            services.AddDbContext<ProductsDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultDatabase")));
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            AutofacRegisterDependenciesConfig.Register(builder);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            UpdateDatabase(app);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Products Api");
            });
        }

        private static void UpdateDatabase(IApplicationBuilder app)
        {
            //using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            //{
            //    using (var context = serviceScope.ServiceProvider.GetService<ProductsDbContext>())
            //    {
            //        context.Database.Migrate();
            //    }
            //}
        }
    }
}
