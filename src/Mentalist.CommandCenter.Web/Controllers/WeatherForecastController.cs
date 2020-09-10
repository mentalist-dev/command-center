using System.Collections.Generic;
using System.Threading.Tasks;
using Mentalist.CommandCenter.Web.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Mentalist.CommandCenter.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ICommandCenter _commands;

        public WeatherForecastController(ICommandCenter commands)
        {
            _commands = commands;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            using var context = _commands.CreateContext(new CommandContextParameters());

            var command = _commands.CreateCommand<GetWeatherForecastCommand>();
            var response = await command.ExecuteAsync(context);
            
            context.Complete();

            return response;
        }
    }
}
