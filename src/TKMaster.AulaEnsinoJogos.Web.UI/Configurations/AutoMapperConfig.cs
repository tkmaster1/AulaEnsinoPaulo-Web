using Microsoft.Extensions.DependencyInjection;
using System;
using TKMaster.AulaEnsinoJogos.Web.UI.AutoMapper;

namespace TKMaster.AulaEnsinoJogos.Web.UI.Configurations
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
        }
    }
}
