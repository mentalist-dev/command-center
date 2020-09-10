using System;

namespace Mentalist.CommandCenter
{
    public interface ICommandCenter: IDisposable
    {
        ICommandContext CreateContext(ICommandContextParameters parameters);
        TCommand CreateCommand<TCommand>() where TCommand : class, ICommand;
    }
}
