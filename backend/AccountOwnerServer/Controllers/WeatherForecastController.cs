using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILoggerManager _logger;

    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInfo("Testando log de info");
        _logger.LogDebug("Testando log de debug");
        _logger.LogError("Testando log de erro");
        _logger.LogWarn("Testando log de aviso");

        return new string[]{
            "value1",
            "value2"
        };
    }
}
