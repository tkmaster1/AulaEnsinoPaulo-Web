using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.BaseService;
using TKMaster.AulaEnsinoJogos.Web.UI.Configurations.Filters;

namespace TKMaster.AulaEnsinoJogos.Web.UI.Configurations
{
    /// <summary>
    /// Classe de configuração do MVC
    /// </summary>
    public static class MvcConfig
    {
        public static IServiceCollection AddMvcConfiguration(this IServiceCollection services, IConfiguration configuartion)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddControllersWithViews(o =>
            {
                o.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });

            services.AddControllers(opt => opt.Filters.Add(typeof(CustomActionFilterConfig)));

            services.AddRazorPages();

            var _appConfig = configuartion.GetSection("AppSettings").Get<ApplicationConfig>();

            services.AddSingleton(_appConfig);
            services.Configure<ApplicationConfig>(configuartion.GetSection("AppSettings"));

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpContextAccessor();

            services.AddCors();

            return services;
        }
    }
}
