using System;

namespace Mentalist.CommandCenter
{
    public interface ICommandContext: IDisposable
    {
        void Complete();
    }
}
