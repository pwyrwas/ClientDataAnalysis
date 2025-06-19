using ClientDataAnalysis.Domain;

namespace ClientDataAnalysis.Application.Interfaces
{
    public interface ICsvService
    {
        Task<List<Client>> ParseClientsAsync(string csvContent);
    }
}
