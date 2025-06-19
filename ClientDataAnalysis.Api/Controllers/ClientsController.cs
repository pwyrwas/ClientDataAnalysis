using ClientDataAnalysis.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClientDataAnalysis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly ILogger<ClientsController> _logger;
        private readonly IClientsService _clientsService;

        public ClientsController(IClientsService clientsService)
        {
            _clientsService = clientsService;
        }


        [HttpGet("average-age")]
        public async Task<IActionResult> GetAverageAge([FromQuery] string sourceUrl)
        {
            var result = await _clientsService.GetAverageAge(sourceUrl);
            return Ok(result);
        }

        [HttpGet("count-by-country")]
        public async Task<IActionResult> GetClientsCountByCountry([FromQuery] string sourceUrl)
        {
            var result = await _clientsService.GetClientsCountByCountry(sourceUrl);
            return Ok(result);
        }
    }
}
