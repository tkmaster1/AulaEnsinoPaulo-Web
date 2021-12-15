using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TKMaster.AulaEnsinoJogos.Web.UI.Configurations;

namespace TKMaster.AulaEnsinoJogos.Web.UI
{
    public class Startup
    {
        #region Propertries

        public IConfiguration Configuration { get; }

        private readonly IWebHostEnvironment _env;

        #endregion

        #region Constructor

        public Startup(IWebHostEnvironment hostEnv)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(hostEnv.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{hostEnv.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();

            _env = hostEnv;

            Configuration = builder.Build();
        }

        #endregion

        #region Methods

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapperConfiguration();

            services.AddHttpClient();

            //Allows auth to be bypassed
            if (_env.IsDevelopment())
                services.AddSingleton<IAuthorizationHandler, AllowAnonymous>();

            services.AddMvcConfiguration(Configuration);

            services.AddDependencyInjectionConfiguration();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseGlobalizationConfig();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        #endregion
    }
}
