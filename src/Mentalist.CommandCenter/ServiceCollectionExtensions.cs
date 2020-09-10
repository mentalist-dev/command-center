using System;
using Mentalist.CommandCenter.Events;
using Microsoft.Extensions.DependencyInjection;

namespace Mentalist.CommandCenter
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCommandCenter<TCommandContextFactory>(this IServiceCollection services, Action<ICommandRegistry> addCommands = null)
            where TCommandContextFactory: class, ICommandContextFactory
        {
            addCommands?.Invoke(new CommandRegistry(services));

            services.AddSingleton<IEventSink, NoOpEventSink>();

            services.AddSingleton<ICommandContextFactory, TCommandContextFactory>();

            return services
                    .AddScoped<ICommandCenter, CommandCenter>()
                ;
        }
    }
}
