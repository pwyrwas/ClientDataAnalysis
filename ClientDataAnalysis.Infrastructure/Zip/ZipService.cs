using ClientDataAnalysis.Application.Interfaces;
using System.IO.Compression;

namespace ClientDataAnalysis.Infrastructure.Zip
{
    public class ZipService : IZipService
    {
        public async Task<string> ExtractCsvAsync(Stream zipStream)
        {
            using var archive = new ZipArchive(zipStream);
            var entry = archive.Entries.FirstOrDefault(e => e.Name == "clients.csv");
            using var reader = new StreamReader(entry.Open());
            return await reader.ReadToEndAsync();
        }
    }
}
