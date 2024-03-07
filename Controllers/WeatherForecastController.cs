using auth_102.repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace auth_102.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{


    private readonly ILogger<WeatherForecastController> _logger;
    private readonly Iweatherforcast _weather;

    public WeatherForecastController(ILogger<WeatherForecastController> logger , Iweatherforcast weather)
    {
        _logger = logger;
        _weather = weather;
    }


    // [Authorize]
    [Authorize]

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return _weather.Get();

    }
}
