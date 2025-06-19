
namespace ClientDataAnalysis.Application.Interfaces
{
    public interface IZipService
    {
        Task<string> ExtractCsvAsync(Stream zipStream);
    }
}
