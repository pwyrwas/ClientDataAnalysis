using ClientDataAnalysis.Application.Interfaces;
using ClientDataAnalysis.Domain;

namespace ClientDataAnalysis.Application.Services
{
    public class ClientDataService : IClientDataService
    {
        private readonly IZipService _zipService;
        private readonly ICsvService _csvService;
        private readonly IHttpClientFactory _httpClientFactory;

        public ClientDataService(IZipService zipService, ICsvService csvService, IHttpClientFactory httpClientFactory)
        {
            _zipService = zipService;
            _csvService = csvService;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<List<Client>> DownloadAndParseClientsAsync(string url)
        {
            var client = _httpClientFactory.CreateClient();
            var stream = await client.GetStreamAsync(url);
            var csvContent = await _zipService.ExtractCsvAsync(stream);
            return await _csvService.ParseClientsAsync(csvContent);
        }
    }
}
