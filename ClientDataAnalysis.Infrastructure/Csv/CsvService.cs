using ClientDataAnalysis.Application.Interfaces;
using ClientDataAnalysis.Domain;

namespace ClientDataAnalysis.Infrastructure.Csv
{
    public class CsvService : ICsvService
    {
        public Task<List<Client>> ParseClientsAsync(string csvContent)
        {
            throw new NotImplementedException();
        }
    }
}
