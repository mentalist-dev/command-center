using System.Collections.Generic;
using System.Threading.Tasks;
using Mentalist.CommandCenter.Events;
using Mentalist.CommandCenter.Web.DataLayer;
using Mentalist.CommandCenter.Web.Events;

namespace Mentalist.CommandCenter.Web.Commands
{
    public class GetWeatherForecastCommand: ICommand
    {
        private readonly WeatherForecastRepository _repository;
        private readonly IEventSink _events;

        public GetWeatherForecastCommand(WeatherForecastRepository repository, IEventSink events)
        {
            _repository = repository;
            _events = events;
        }

        public async Task<IEnumerable<WeatherForecast>> ExecuteAsync(ICommandContext context)
        {
            var logCommand = context.Commands.CreateCommand<LogWeatherForecastRequestCommand>();
            logCommand.Execute(context);

            var repository = _repository(context);
            var response = repository.Get();

            await _events.Push(new WeatherForecastRequestedEvent());

            return response;
        }
    }
}
