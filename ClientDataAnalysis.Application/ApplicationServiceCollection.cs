using ClientDataAnalysis.Application.Interfaces;
using ClientDataAnalysis.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClientDataAnalysis.Application
{
    public static class ApplicationServiceCollection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IClientsService, ClientService>();
            return services;
        }
    }
}
