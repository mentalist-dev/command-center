using System;
using System.Collections.Generic;
using System.Linq;

namespace Mentalist.CommandCenter.Web.DataLayer
{
    public delegate IWeatherForecastDataRepository WeatherForecastRepository(ICommandContext context);

    public interface IWeatherForecastDataRepository
    {
        IEnumerable<WeatherForecast> Get();
    }

    public class WeatherForecastDataRepository : IWeatherForecastDataRepository
    {
        private readonly ICommandContext _context;

        private static readonly string[] Summaries = {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastDataRepository(ICommandContext context)
        {
            _context = context;
        }

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToArray();
        }
    }
}
