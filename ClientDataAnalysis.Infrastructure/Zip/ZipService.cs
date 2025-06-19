using ClientDataAnalysis.Application.Interfaces;

namespace ClientDataAnalysis.Infrastructure.Zip
{
    public class ZipService : IZipService
    {
        public Task<string> ExtractCsvAsync(Stream zipStream)
        {
            throw new NotImplementedException();
        }
    }
}
