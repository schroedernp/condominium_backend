using Microsoft.AspNetCore.Mvc;

namespace condominium_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        var teste = new WeatherForecast(DateTime.Now);

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast(DateTime.Now)
        {
            Date = null,
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = null
        })
        .ToArray();
    }
}
