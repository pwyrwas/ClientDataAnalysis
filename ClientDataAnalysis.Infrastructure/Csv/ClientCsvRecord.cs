using ClientDataAnalysis.Domain;
using CsvHelper.Configuration;

namespace ClientDataAnalysis.Infrastructure.Csv
{
    public sealed class ClientCsvMap : ClassMap<Client>
    {
        public ClientCsvMap()
        {
            Map(m => m.FirstName).Name("FirstName");
            Map(m => m.LastName).Name("LastName");
            Map(m => m.Country).Name("Country");
            Map(m => m.BirthDate)
                .Name("BirthDate")
                .TypeConverterOption.Format("yyyy-MM-dd");
        }
    }
}
