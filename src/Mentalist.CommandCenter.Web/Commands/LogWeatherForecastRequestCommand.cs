using System;

namespace Mentalist.CommandCenter.Web.Commands
{
    public class LogWeatherForecastRequestCommand: ICommand
    {
        public void Execute(ICommandContext context)
        {
            Console.WriteLine("Weather forecast request received");
        }
    }
}
