using ClientDataAnalysis.Application.Interfaces;
using ClientDataAnalysis.Domain;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace ClientDataAnalysis.Infrastructure.Csv
{
    public class CsvService : ICsvService
    {
        public Task<List<Client>> ParseClientsAsync(string csvContent)
        {
            using var reader = new StringReader(csvContent);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.Trim(),
                MissingFieldFound = null,
                BadDataFound = null,
                HeaderValidated = null,
            });

            csv.Context.RegisterClassMap<ClientCsvMap>();

            var records = csv.GetRecords<Client>()
                             .Select(r => new Client
                             {
                                 FirstName = r.FirstName,
                                 LastName = r.LastName,
                                 Country = r.Country,
                                 BirthDate = r.BirthDate
                             })
                             .ToList();

            return Task.FromResult(records);
        }
    }
}
