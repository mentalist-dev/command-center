using System.Reflection;

namespace Mentalist.CommandCenter
{
    public interface ICommandRegistry
    {
        ICommandRegistry Add<TCommand>() where TCommand : class, ICommand;

        ICommandRegistry FromAssembly(Assembly assembly);
    }
}