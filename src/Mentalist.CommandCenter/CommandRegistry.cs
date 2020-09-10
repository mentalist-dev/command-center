using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Mentalist.CommandCenter
{
    internal class CommandRegistry : ICommandRegistry
    {
        private readonly IServiceCollection _services;

        public CommandRegistry(IServiceCollection services)
        {
            _services = services;
        }

        public ICommandRegistry Add<TCommand>() where TCommand : class, ICommand
        {
            _services.AddTransient<TCommand>();
            return this;
        }

        public ICommandRegistry FromAssembly(Assembly assembly)
        {
            var types = assembly
                .GetTypes()
                .Where(t => typeof(ICommand).IsAssignableFrom(t) && t.IsClass);

            foreach (var type in types)
            {
                _services.Add(new ServiceDescriptor(type, type, ServiceLifetime.Transient));
            }

            return this;
        }
    }
}