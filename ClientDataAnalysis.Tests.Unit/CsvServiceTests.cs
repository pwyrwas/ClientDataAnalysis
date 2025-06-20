using ClientDataAnalysis.Application.Interfaces;
using ClientDataAnalysis.Infrastructure.Csv;
using System.Text;

namespace ClientDataAnalysis.Tests.Unit;

public class CsvServiceTests
{
    [Fact]
    public async Task ParseClientsAsync_ValidCsv_ReturnsParsedClients()
    {
        // Arrange
        var csvContent = @"FirstName,LastName,Country,BirthDate
        Jan,Kowalski,Polska,1980-05-12
        Anna,Nowak,Niemcy,1990-11-03";

        var csvService = new CsvService();

        // Act
        var clients = await csvService.ParseClientsAsync(csvContent);

        // Assert
        Assert.Equal(2, clients.Count);
        Assert.Equal("Jan", clients[0].FirstName);
        Assert.Equal("Nowak", clients[1].LastName);
        Assert.Equal("Niemcy", clients[1].Country);
        Assert.Equal(new DateTime(1990, 11, 3), clients[1].BirthDate);
    }
}
