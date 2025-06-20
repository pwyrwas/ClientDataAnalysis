using Microsoft.AspNetCore.Mvc.Testing;

namespace ClientDataAnalysis.Tests.Integration;

public class ClientsControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ClientsControllerTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetAverageAge_ReturnsSuccessAndValue()
    {
        string csvUrl = "https://github.com/pwyrwas/ClientDataAnalysis/releases/download/1.0/sample-clients.zip";

        var response = await _client.GetAsync($"Clients/average-age?sourceUrl={Uri.EscapeDataString(csvUrl)}");

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadAsStringAsync();

        Assert.False(string.IsNullOrWhiteSpace(result));
        Assert.Equal("41.75", result);

    }
}
