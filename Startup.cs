using FluentValidation;
using FluentValidation.AspNetCore;

namespace fluentnestedtest;

public class Startup
{
    public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            HostEnvironment = environment;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment HostEnvironment { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvcCore();
            
            services.AddFluentValidationAutoValidation(config => 
            {
                config.DisableDataAnnotationsValidation = true;
            });
            
            services.AddValidatorsFromAssemblyContaining<ThingValidator>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
}