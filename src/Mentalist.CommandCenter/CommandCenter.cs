using System;
using Microsoft.Extensions.DependencyInjection;

namespace Mentalist.CommandCenter
{
    internal class CommandCenter: ICommandCenter
    {
        private readonly ICommandContextFactory _commandContextFactory;
        private readonly IServiceScope _serviceScope;

        public IServiceProvider Services => _serviceScope.ServiceProvider;

        public CommandCenter(IServiceScopeFactory scopeFactory, ICommandContextFactory commandContextFactory)
        {
            _commandContextFactory = commandContextFactory;
            _serviceScope = scopeFactory.CreateScope();
        }

        public ICommandContext CreateContext(ICommandContextParameters parameters)
        {
            return _commandContextFactory.Create(this, parameters);
        }

        public TCommand CreateCommand<TCommand>() where TCommand : class, ICommand
        {
            var commandType = typeof(TCommand);

            if (!(Services.GetService(commandType) is TCommand command))
                throw new CommandNotRegisteredException(commandType);

            return command;
        }

        public void Dispose()
        {
            _serviceScope?.Dispose();
        }
    }
}