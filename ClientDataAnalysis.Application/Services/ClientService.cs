
using ClientDataAnalysis.Application.Interfaces;

namespace ClientDataAnalysis.Application.Services
{
    public class ClientService : IClientsService
    {
        private readonly IClientDataService _clientDataService;

        public ClientService(IClientDataService clientDataService)
        {
            _clientDataService = clientDataService;
        }

        public async Task<double> GetAverageAge(string url)
        {
            var clients = await _clientDataService.DownloadAndParseClientsAsync(url);

            return clients.Average(c => c.GetAge());
        }

        public async Task<Dictionary<string, int>> GetClientsCountByCountry(string url)
        {
            var clients = await _clientDataService.DownloadAndParseClientsAsync(url);

            return clients.GroupBy(client => client.Country).ToDictionary(
                groupedClients => groupedClients.Key,
                groupedClients => groupedClients.Count());
        }
    }
}
