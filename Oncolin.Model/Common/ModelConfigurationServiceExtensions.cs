using Microsoft.Extensions.DependencyInjection;
using Oncolin.Entities;

namespace Oncolin.Model.Common
{
    public static class ModelConfigurationServiceExtensions
    {
        public static IServiceCollection AddModel(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ModelConfigurationServiceExtensions).Assembly, typeof(IEntity).Assembly);

            return services;
        }
    }
}
