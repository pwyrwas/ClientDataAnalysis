using ClientDataAnalysis.Domain;

namespace ClientDataAnalysis.Application.Interfaces
{
    public interface IClientDataService
    {
        Task<List<Client>> DownloadAndParseClientsAsync(string url);
    }
}
