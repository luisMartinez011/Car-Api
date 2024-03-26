using CarApi.Data.Config;
using CarApi.Models;
using CarApi.Models.SeederData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        private CarConfiguration carConfiguration;
        private CountryConfiguration countryConfiguration;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            CountryConfiguration _countryConfiguration, CarConfiguration _carConfiguration)
        {
            countryConfiguration = _countryConfiguration;
            carConfiguration = _carConfiguration;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("/carData")]
        public async Task<ActionResult<List<CarSeeder>>> GetCarritos()
        {

            
            return await carConfiguration.GetCarDataAsync();
        }

        [HttpGet("/countryData")]
        public  List<CountrySeeder> GetCountry()
        {


            return  countryConfiguration.GetCountryDataAsync();
        }
    }
}