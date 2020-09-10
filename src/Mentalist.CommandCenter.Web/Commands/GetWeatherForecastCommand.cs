using System.Collections.Generic;
using Mentalist.CommandCenter.Web.DataLayer;

namespace Mentalist.CommandCenter.Web.Commands
{
    public class GetWeatherForecastCommand: ICommand
    {
        private readonly WeatherForecastRepository _repository;

        public GetWeatherForecastCommand(WeatherForecastRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<WeatherForecast> Execute(ICommandContext context)
        {
            return _repository(context).Get();
        }
    }
}
