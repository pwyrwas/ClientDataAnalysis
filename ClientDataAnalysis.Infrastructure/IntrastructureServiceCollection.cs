using ClientDataAnalysis.Application.Interfaces;
using ClientDataAnalysis.Infrastructure.ClientData;
using ClientDataAnalysis.Infrastructure.Csv;
using ClientDataAnalysis.Infrastructure.Zip;
using Microsoft.Extensions.DependencyInjection;

namespace ClientDataAnalysis.Infrastructure
{
    public static class IntrastructureServiceCollection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ICsvService, CsvService>();
            services.AddTransient<IZipService, ZipService>();
            services.AddTransient<IClientDataService, ClientDataService>();
            return services;
        }
    }
}
