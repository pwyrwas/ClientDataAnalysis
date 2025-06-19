
using ClientDataAnalysis.Domain;

namespace ClientDataAnalysis.Application.Interfaces
{
    public interface IClientsService
    {
        Task<double> GetAverageAge(string url);
        Task<Dictionary<string, int>> GetClientsCountByCountry(string url);
    }
}
