using System;

namespace Mentalist.CommandCenter
{
    public interface ICommandContext: IDisposable
    {
        ICommandCenter Commands { get; }
        void Complete();
    }
}
